package ChargeurTransformice_fla.Forms
{
   import ChargeurTransformice_fla.*;
   import coms.bit101.components.*;
   import flash.display.*;
   import flash.events.*;
   import flash.net.*;
   import flash.system.*;
   import flash.text.*;
   import flash.ui.*;
   import flash.utils.*;
   
   public dynamic class Shaman extends MovieClip
   {
       
      
      public var Key_:Object;
      
      public var tfm;
      
      public var hackClass;
      
      public var mainForm:MainForm;
      
      public var main_:TransformiceChargeur;
      
      public var _sprite:Sprite;
      
      public var lastMap:int = 0;
      
      var sendConjuration:Boolean = false;
      
      public function Shaman(param1:*)
      {
         super();
         this.Key_ = param1.Key_;
         this.tfm = param1.tfm;
         this.hackClass = param1.hackClass;
         this.main_ = TransformiceChargeur.instance;
         this._sprite = new Sprite();
         param1.menu_ui.addChild(this);
         this.addChild(this._sprite);
         this.setDict("cb_RocketMouse",new CheckBox(this._sprite,10,10,Language.getText("RocketMouse")));
         this.setDict("cb_SpeedyBalloon",new CheckBox(this._sprite,10,30,Language.getText("SpeedyBalloon")));
         this.setDict("cb_FastCreating",new CheckBox(this._sprite,10,50,Language.getText("FastCreating")));
         this.setDict("cb_Wings",new CheckBox(this._sprite,10,90,Language.getText("Wings")));
         this.setDict("cb_ItemEveryWhere",new CheckBox(this._sprite,10,70,Language.getText("DivineMode")));
         this.setDict("cb_Shameow",new CheckBox(this._sprite,230,10,Language.getText("Shameow") + " - [G]"));
         this.setDict("cb_Conjuration",new CheckBox(this._sprite,230,30,Language.getText("Conjuration") + " - [Mouse]",function():*
         {
            Conjuration(Dict.theDict.cb_Conjuration.selected);
         }));
         this.setDict("cb_Portal",new CheckBox(this._sprite,230,50,"Portal - [T/R]"));
         this.setDict("pb_KillAll",new PushButton(this._sprite,230,70,Language.getText("KillAll"),function():*
         {
            KillALL();
         }));
         Dict.theDict.ShamanKeyboard = this.keyboard;
         Dict.theDict.ShamanLoop = function():*
         {
            Key_.DistanceInvocClass[Key_.DistanceInvoc] = 120;
            if(Dict.theDict.cb_Wings.selected)
            {
               if(hackClass.myMouse[Key_.getWing] == null)
               {
                  hackClass.myMouse[Key_.Guide] = Dict._true;
                  hackClass.myMouse[Key_.getWing] = new Key_.setWing(hackClass.myMouse);
               }
            }
            if(Dict.theDict.cb_RocketMouse.selected)
            {
               hackClass.myMouse[Key_.Guide] = Dict._true;
               setRocketMouse();
            }
            if(Dict.theDict.cb_ItemEveryWhere.selected)
            {
               Key_.DistanceInvocClass[Key_.DistanceInvoc] = 9999;
            }
            if(hackClass.myMouse[Key_.Guide])
            {
               if(Dict.theDict.cb_SpeedyBalloon.selected)
               {
                  setBalloonSpeed();
               }
               if(Dict.theDict.cb_FastCreating.selected)
               {
                  setFastCreate();
               }
            }
         };
      }
      
      public function setDict(param1:*, param2:*) : *
      {
         Dict.theDict[param1] = param2;
      }
      
      public function setRocketMouse(param1:int = 10) : *
      {
         this.ShamanSkillPacket(90138,param1);
      }
      
      public function setBalloonSpeed(param1:int = 5000) : *
      {
         this.ShamanSkillPacket(45,param1);
      }
      
      public function setFastCreate() : *
      {
         this.ShamanSkillPacket(49,0);
      }
      
      public function Transformation_Cat() : *
      {
         var _loc1_:* = new ByteArray();
         _loc1_.writeInt(Dict.theDict.playerCode);
         _loc1_.writeByte(1);
         TransformiceChargeur.instance.ParsePacket(5,43,_loc1_);
      }
      
      public function ShamanSkillPacket(param1:int, param2:int) : void
      {
         var _loc3_:* = new ByteArray();
         _loc3_.writeByte(param1);
         _loc3_.writeByte(param2);
         TransformiceChargeur.instance.ParsePacket(8,10,_loc3_);
      }
      
      public function KillALL(param1:Boolean = false) : *
      {
         if(!this.hackClass.myMouse[this.Key_.Guide])
         {
            return;
         }
         var _loc2_:* = this.AliveMouse;
         if(Dict.theDict.map_code_int != this.lastMap && !param1)
         {
            this.lastMap = Dict.theDict.map_code_int;
            this.hackClass.Object_creation(26,_loc2_.x,_loc2_.y);
            this.hackClass.Object_creation(27,-99999,-999999);
            setTimeout(this.KillALL,1500);
            return;
         }
         if(Dict.theDict.map_code_int == this.lastMap)
         {
            this.hackClass.Object_creation(26,_loc2_.x,_loc2_.y);
            this.hackClass.Object_creation(27,-99999,-999999);
            setTimeout(this.KillALL,1500,true);
         }
      }
      
      public function get AliveMouse() : *
      {
         var _loc1_:String = "";
         for each(users in this.tfm[this.Key_.ListeJoueur])
         {
            if(!users[this.Key_.Mort] && users != this.hackClass.myMouse)
            {
               return users;
            }
         }
      }
      
      public function activating(param1:* = null) : *
      {
         stage.addEventListener(MouseEvent.MOUSE_MOVE,this.mouse_move);
      }
      
      public function deactivating(param1:* = null) : *
      {
         stage.removeEventListener(MouseEvent.MOUSE_MOVE,this.mouse_move);
      }
      
      public function mouse_move(param1:* = null) : *
      {
         if(this.sendConjuration)
         {
            this.hackClass.Conjuration();
         }
      }
      
      public function Conjuration(param1:Boolean) : *
      {
         this.sendConjuration = param1;
         if(param1)
         {
            stage.addEventListener(MouseEvent.MOUSE_DOWN,this.activating);
            stage.addEventListener(MouseEvent.MOUSE_UP,this.deactivating);
         }
         else
         {
            stage.removeEventListener(MouseEvent.MOUSE_DOWN,this.activating);
            stage.removeEventListener(MouseEvent.MOUSE_UP,this.deactivating);
         }
      }
      
      public function keyboard(param1:*) : *
      {
         var _loc2_:* = param1;
         if(_loc2_ == Keyboard.G && Dict.theDict.cb_Shameow.selected)
         {
            this.Transformation_Cat();
         }
         if(_loc2_ == Keyboard.T && Dict.theDict.cb_Portal.selected)
         {
            this.hackClass.Object_creation(26,TransformiceChargeur.instance.getMouseLOC(true),TransformiceChargeur.instance.getMouseLOC(false));
         }
         if(_loc2_ == Keyboard.R && Dict.theDict.cb_Portal.selected)
         {
            this.hackClass.Object_creation(27,TransformiceChargeur.instance.getMouseLOC(true),TransformiceChargeur.instance.getMouseLOC(false));
         }
      }
   }
}
