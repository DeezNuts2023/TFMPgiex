package ChargeurTransformice_fla
{
   import flash.display.*;
   import flash.net.*;
   import flash.utils.*;
   
   public dynamic class Functions extends MovieClip
   {
       
      
      public var CheeHoleC:Object;
      
      public var MS_Mort:Object;
      
      public var MoteurReseau:Object;
      
      public var AFKc:Object;
      
      public var ClassPackt:Object;
      
      public var ClassReciv:Object;
      
      public var Puloc:Object;
      
      public var CreationClass:Object;
      
      public var Object_Guide:Object;
      
      public var Instance:Object;
      
      public var serveur:Object;
      
      public var Idsend:Object;
      
      public var Recive:Object;
      
      public var Key_:Keys;
      
      public var tfm:Object;
      
      public function Functions()
      {
         super();
         this.Key_ = new Keys();
      }
      
      public function InstantChesse() : void
      {
         var _loc1_:* = new ByteArray();
         _loc1_.writeInt(this.tfm[this.Key_.CodeEnPart]);
         _loc1_.writeShort(this.CheeHoleC[this.Key_.CheeHole1][this.Key_.ClipFromage].x);
         _loc1_.writeShort(this.CheeHoleC[this.Key_.CheeHole1][this.Key_.ClipFromage].y);
         _loc1_.writeShort(0);
         this.SendPacket(5,19,_loc1_);
      }
      
      public function ApplyMovePlayer(param1:int, param2:int, param3:Boolean, param4:int, param5:int, param6:Boolean) : void
      {
         var _loc7_:*;
         (_loc7_ = new ByteArray()).writeShort(param1);
         _loc7_.writeShort(param2);
         _loc7_.writeBoolean(param3);
         _loc7_.writeShort(param4);
         _loc7_.writeShort(param5);
         _loc7_.writeBoolean(param6);
         this.ParsePacket(8,3,_loc7_);
      }
      
      public function SetPlayerPosition(param1:Number, param2:Number) : void
      {
         this.ApplyMovePlayer(param1,param2,false,0,0,false);
      }
      
      public function ParseOldPacket(param1:int, param2:int, ... rest) : void
      {
         var _loc6_:* = undefined;
         var _loc4_:ByteArray = new ByteArray();
         var _loc5_:ByteArray;
         (_loc5_ = new ByteArray()).writeByte(param1);
         _loc5_.writeByte(param2);
         for each(_loc6_ in rest)
         {
            _loc5_.writeByte(1);
            _loc5_.writeUTFBytes(_loc6_);
         }
         _loc4_.writeShort(_loc5_.length);
         _loc4_.writeBytes(_loc5_,0,_loc5_.length);
         this.ParsePacket(1,1,_loc4_);
      }
      
      public function ParsePacket(param1:int, param2:int, param3:ByteArray) : void
      {
         var _loc4_:*;
         (_loc4_ = new ByteArray()).writeByte(param1);
         _loc4_.writeByte(param2);
         _loc4_.writeBytes(param3);
         this.ClassReciv[this.Recive](_loc4_);
      }
      
      public function MovePlayer(param1:int, param2:int, param3:Boolean) : void
      {
         this.ApplyMovePlayer(0,0,false,param1,param2,param3);
      }
      
      public function get PSockt() : Socket
      {
         return this.ClassPackt[this.Instance][this.serveur];
      }
      
      public function SendOldPacket(param1:int, param2:int, ... rest) : void
      {
         var _loc6_:* = undefined;
         var _loc4_:ByteArray = new ByteArray();
         var _loc5_:ByteArray;
         (_loc5_ = new ByteArray()).writeByte(param1);
         _loc5_.writeByte(param2);
         for each(_loc6_ in rest)
         {
            _loc5_.writeByte(1);
            _loc5_.writeUTFBytes(_loc6_);
         }
         _loc4_.writeShort(_loc5_.length);
         _loc4_.writeBytes(_loc5_,0,_loc5_.length);
         this.SendPacket(1,1,_loc4_);
      }
      
      public function SendPacket(param1:int, param2:int, param3:ByteArray) : void
      {
         var _loc4_:*;
         (_loc4_ = new ByteArray()).writeByte(param1);
         _loc4_.writeByte(param2);
         _loc4_.writeBytes(param3);
         this.MoteurReseau[this.Key_.Satellite][this.Key_._envoieMessage](_loc4_);
      }
   }
}
