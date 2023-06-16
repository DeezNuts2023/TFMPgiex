package coms.adobe.serialization.json
{
   import ChargeurTransformice_fla.*;
   import flash.utils.*;
   
   public class JSONEncoder
   {
       
      
      private var jsonString:String;
      
      public function JSONEncoder(param1:*)
      {
         super();
         this.jsonString = this.convertToString(param1);
      }
      
      public function getString() : String
      {
         return this.jsonString;
      }
      
      private function convertToString(param1:*) : String
      {
         if(param1 is String)
         {
            return this.escapeString(param1 as String);
         }
         if(param1 is Number)
         {
            return !!isFinite(param1 as Number) ? param1.toString() : "null";
         }
         if(param1 is Boolean)
         {
            return !!param1 ? "true" : "false";
         }
         if(param1 is Array)
         {
            return this.arrayToString(param1 as Array);
         }
         if(param1 is Object && param1 != null)
         {
            return this.objectToString(param1);
         }
         return "null";
      }
      
      private function escapeString(param1:String) : String
      {
         var _loc2_:String = null;
         var _loc3_:String = null;
         var _loc4_:String = null;
         var _loc5_:* = "";
         var _loc6_:Number = param1.length;
         var _loc7_:int = 0;
         while(_loc7_ < _loc6_)
         {
            _loc2_ = param1.charAt(_loc7_);
            switch(_loc2_)
            {
               case "\"":
                  _loc5_ += "\\\"";
                  break;
               case "\\":
                  _loc5_ += "\\\\";
                  break;
               case "\b":
                  _loc5_ += "\\b";
                  break;
               case "\f":
                  _loc5_ += "\\f";
                  break;
               case "\n":
                  _loc5_ += "\\n";
                  break;
               case "\r":
                  _loc5_ += "\\r";
                  break;
               case "\t":
                  _loc5_ += "\\t";
                  break;
               default:
                  if(_loc2_ < " ")
                  {
                     _loc4_ = (_loc3_ = _loc2_.charCodeAt(0).toString(16)).length == 2 ? "00" : "000";
                     _loc5_ += "\\u" + _loc4_ + _loc3_;
                  }
                  else
                  {
                     _loc5_ += _loc2_;
                  }
                  break;
            }
            _loc7_++;
         }
         return "\"" + _loc5_ + "\"";
      }
      
      private function arrayToString(param1:Array) : String
      {
         var _loc2_:* = "";
         var _loc3_:int = param1.length;
         var _loc4_:int = 0;
         while(_loc4_ < _loc3_)
         {
            if(_loc2_.length > 0)
            {
               _loc2_ += ",";
            }
            _loc2_ += this.convertToString(param1[_loc4_]);
            _loc4_++;
         }
         return "[" + _loc2_ + "]";
      }
      
      private function objectToString(param1:Object) : String
      {
         var value:Object = null;
         var key:String = null;
         var v:XML = null;
         var o:Object = param1;
         var s:String = "";
         var classInfo:XML = describeType(o);
         if(classInfo.@name.toString() == "Object")
         {
            for(key in o)
            {
               value = o[key];
               if(!(value is Function))
               {
                  if(s.length > 0)
                  {
                     s += ",";
                  }
                  s += this.escapeString(key) + ":" + this.convertToString(value);
               }
            }
         }
         else
         {
            for each(v in classInfo..*.(name() == "variable" || name() == "accessor" && attribute("access").charAt(0) == "r"))
            {
               if(!(v.metadata && v.metadata.(@name == "Transient").length() > 0))
               {
                  if(s.length > 0)
                  {
                     s += ",";
                  }
                  s += this.escapeString(v.@name.toString()) + ":" + this.convertToString(o[v.@name]);
               }
            }
         }
         return "{" + s + "}";
      }
   }
}
