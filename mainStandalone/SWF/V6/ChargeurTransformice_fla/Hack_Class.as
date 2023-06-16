package ChargeurTransformice_fla
{
   import flash.display.*;
   import flash.events.*;
   import flash.net.*;
   import flash.system.*;
   import flash.text.*;
   import flash.ui.*;
   import flash.utils.*;
   
   public dynamic class Hack_Class extends MovieClip
   {
       
      
      public var instance:Hack_Class;
      
      public var Key_:Object;
      
      public var tfm;
      
      public var main_:TransformiceChargeur;
      
      public function Hack_Class(param1:*)
      {
         this.instance = this;
         super();
         this.Key_ = Dict.theDict.Key_;
         this.tfm = param1.tfm;
         this.main_ = TransformiceChargeur.instance;
      }
      
      public function get cheeseX() : *
      {
         return this.Key_.CheeHoleC[this.Key_.CheeHole1][this.Key_.ClipFromage];
      }
      
      public function get holeList() : *
      {
         return this.Key_.CheeHoleC[this.Key_.CheeHole1][this.Key_.Hole2][this.Key_.LsTS];
      }
      
      public function get myMouse() : *
      {
         return this.tfm[this.Key_.ClipJoueur];
      }
      
      public function mouse_Info(param1:* = null) : *
      {
         if(param1 == "name")
         {
            return this.tfm[this.Key_.ClipJoueur][this.Key_.GameName];
         }
         if(param1 == "mort")
         {
            return this.tfm[this.Key_.ClipJoueur][this.Key_.Mort];
         }
         if(param1 == "grosse")
         {
            return this.tfm[this.Key_.ClipJoueur][this.Key_.Grosse];
         }
         if(param1 == "MovingRight")
         {
            return this.tfm[this.Key_.ClipJoueur][this.Key_.MovingRight];
         }
         return this.tfm[this.Key_.ClipJoueur];
      }
      
      public function SetPlayerPosition(param1:Number, param2:Number) : void
      {
         this.main_.ApplyMovePlayer(param1,param2,false,0,0,false);
      }
      
      public function SetPlayerFakePosition(param1:Number, param2:Number) : void
      {
         this.tfm[this.Key_.ClipJoueur].x = param1;
         this.tfm[this.Key_.ClipJoueur].y = param2;
      }
      
      public function Conjuration() : void
      {
         this.main_.ParseOldPacket(4,14,mouseX / 10,mouseY / 10);
         setTimeout(this.Destroy_Conjuration,5000,mouseX / 10,mouseY / 10);
      }
      
      public function Destroy_Conjuration(param1:*, param2:*) : void
      {
         this.main_.ParseOldPacket(4,15,param1,param2);
      }
      
      public function Object_creation(param1:int, param2:int, param3:int, param4:int = 0, param5:Number = 0, param6:Number = 0, param7:Boolean = true) : *
      {
         this.CSynchroniseur();
         this.tfm[this.Key_.ClipJoueur][this.Key_.Guide] = true;
         this.tfm[this.Key_.Guide] = true;
         return this.Key_.CreationClass[this.Key_.Creation_Object](param1,param2,param3,param4,param5,param6,param7);
      }
      
      public function CSynchroniseur() : void
      {
         try
         {
            this.Key_.CSync[this.Key_.Synchroniseur] = true;
         }
         catch(E:Error)
         {
         }
      }
      
      public function setGrosse(param1:Boolean = false, param2:Boolean = false) : void
      {
         if(param1)
         {
            this.tfm[this.Key_.ClipJoueur][this.Key_.Grosse] = param2;
         }
         else
         {
            this.tfm[this.Key_.ClipJoueur][this.Key_.Grosse] = !this.tfm[this.Key_.ClipJoueur][this.Key_.Grosse];
         }
      }
      
      public function setMoveRight(param1:Boolean = false, param2:Boolean = false) : void
      {
         if(param1)
         {
            this.tfm[this.Key_.ClipJoueur][this.Key_.MovingRight] = param2;
         }
         else
         {
            this.tfm[this.Key_.ClipJoueur][this.Key_.MovingRight] = true;
         }
      }
      
      public function get isDead() : *
      {
         return this.tfm[this.Key_.ClipJoueur] == null ? false : this.tfm[this.Key_.ClipJoueur][this.Key_.Mort];
      }
      
      public function chatCommand(param1:String = null) : *
      {
         this.tfm[this.Key_["chatCommand"]](param1);
      }
      
      public function sendChatMessage(param1:String = null) : *
      {
         this.Key_.class_admin[this.Key_.set_admin] = true;
         this.Key_.ChatTribulle[this.Key_.ProxyInstance][this.Key_.validationMessage](param1);
      }
      
      public function sendPrivMessage(param1:String = null, param2:String = null) : *
      {
         this.Key_.class_admin[this.Key_.set_admin] = true;
         this.Key_.ProxyTribulle[this.Key_.ProxyInstance][this.Key_.envoieMsgPrive](param1,param2);
      }
      
      public function TeleWin() : *
      {
         if(!this.isDead)
         {
            this.SetPlayerPosition(this.cheeseX.x + 1,this.cheeseX.y + 1);
            setTimeout(this.SetPlayerPosition,150,this.holeList[1],this.holeList[2]);
            Dict.theDict.mainForm.form_Farm.updateWinCount();
         }
      }
      
      public function set jumpulo(param1:Number) : *
      {
         this.Key_.Puloc[this.Key_.Pulo1][this.Key_.Pulo2] = param1;
      }
      
      public function set leve(param1:Number) : *
      {
         this.Key_.Leve_C[this.Key_.Leve_1] = false;
         this.Key_.LeveC[this.Key_.Leve1](this.tfm[this.Key_.ClipJoueur],param1);
      }
      
      public function set MouseSize(param1:Number) : *
      {
         this.tfm[this.Key_.ClipJoueur][this.Key_.set_mouseSize](param1);
      }
      
      public function set cheeseSize(param1:Number) : *
      {
         if(param1 < 10)
         {
            if(this.cheeseX.width >= 30)
            {
               this.ShamanSkillPacket(257,50);
            }
         }
         else if(param1 > 10 && param1 < 20)
         {
            if(this.cheeseX.width <= 30)
            {
               this.ShamanSkillPacket(257,200);
            }
            if(this.cheeseX.width >= 90)
            {
               this.ShamanSkillPacket(257,50);
            }
         }
         else if(param1 > 20)
         {
            if(this.cheeseX.width <= 90)
            {
               this.ShamanSkillPacket(257,200);
            }
         }
      }
      
      public function ShamanSkillPacket(param1:int, param2:int) : void
      {
         var _loc3_:* = new ByteArray();
         _loc3_.writeByte(param1);
         _loc3_.writeByte(param2);
         this.main_.ParsePacket(8,10,_loc3_);
      }
      
      public function MovePlayer(param1:int, param2:int, param3:Boolean = false) : void
      {
         this.main_.ApplyMovePlayer(0,0,false,param1,param2,param3);
      }
      
      public function send_crouch_packet(param1:int = 0) : void
      {
         var _loc2_:* = new ByteArray();
         _loc2_.writeByte(param1);
         this.main_.SendPacket(4,9,_loc2_);
      }
      
      public function removeStartPeriod() : void
      {
         var _loc1_:* = new ByteArray();
         _loc1_.writeBoolean(false);
         this.main_.ParsePacket(5,10,_loc1_);
      }
      
      public function InstantDeath() : void
      {
         var _loc1_:* = new ByteArray();
         _loc1_.writeInt(this.main_._Dict.round_code);
         _loc1_.writeByte(0);
         this.main_.SendPacket(4,5,_loc1_);
      }
      
      public function InstantWin() : void
      {
         this.send_cheese_packet();
         this.send_hole_packet();
      }
      
      public function send_cheese_packet() : void
      {
         var _loc1_:* = new ByteArray();
         _loc1_.writeInt(Dict.theDict.round_code);
         _loc1_.writeShort(this.cheeseX.x);
         _loc1_.writeShort(this.cheeseX.y);
         _loc1_.writeByte(0);
         _loc1_.writeShort(15);
         this.main_.SendPacket(5,19,_loc1_);
      }
      
      public function send_hole_packet() : void
      {
         var _loc1_:* = new ByteArray();
         _loc1_.writeByte(this.holeList[0]);
         _loc1_.writeInt(Dict.theDict.round_code);
         _loc1_.writeInt(Dict.theDict.map_code_int);
         _loc1_.writeShort(15);
         _loc1_.writeShort(this.holeList[1]);
         _loc1_.writeShort(this.holeList[2]);
         this.main_.SendPacket(5,18,_loc1_);
      }
   }
}
