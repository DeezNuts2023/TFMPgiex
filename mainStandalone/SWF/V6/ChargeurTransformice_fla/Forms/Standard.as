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
   
   public dynamic class Standard extends MovieClip
   {
       
      
      public var Key_:Object;
      
      public var tfm;
      
      public var hackClass;
      
      public var mainForm:MainForm;
      
      public var main_:TransformiceChargeur;
      
      public var _sprite:Sprite;
      
      public var _sprite2:Sprite;
      
      public var cb_Teleport:CheckBox;
      
      public var cb_FakeTeleport:CheckBox;
      
      public var cb_Fly:CheckBox;
      
      public var cb_HideShowCheese:CheckBox;
      
      public var cb_InstantCheese:CheckBox;
      
      public var cb_InstantWin:CheckBox;
      
      public var cb_Immortal:CheckBox;
      
      public var cb_Kill:CheckBox;
      
      public var cb_AutoPlay:CheckBox;
      
      public var cb_Dress:CheckBox;
      
      public var cb_Title:CheckBox;
      
      public var cb_StartEarly:CheckBox;
      
      public var cb_HidePlayers:CheckBox;
      
      public var cb_HideMe:CheckBox;
      
      public var ip_Dress:InputText;
      
      public var ip_Title:InputText;
      
      public var lb_Title:Label;
      
      public var lb_Dress:Label;
      
      public var lb_StartEarly:Label;
      
      public var lb_Delay:Label;
      
      public var ip_Delay:InputText;
      
      public var sb_StartEarly:Slider;
      
      public var sb_AutoPlay:Slider;
      
      public var lb_AutoPlay:Label;
      
      public function Standard(param1:*)
      {
         super();
         this.Key_ = param1.Key_;
         this.tfm = param1.tfm;
         this.mainForm = param1;
         this.hackClass = param1.hackClass;
         this.main_ = TransformiceChargeur.instance;
         this._sprite = new Sprite();
         this._sprite2 = new Sprite();
         param1.menu_ui.addChild(this);
         this.addChild(this._sprite);
         this.addChild(this._sprite2);
         this.cb_Teleport = new CheckBox(this._sprite,10,10,Language.getText("Teleport") + " - [F]");
         this.cb_FakeTeleport = new CheckBox(this._sprite,10,30,Language.getText("FakeTeleport") + " - [V]");
         this.cb_Fly = new CheckBox(this._sprite,10,50,Language.getText("Fly") + " - [W]");
         this.cb_HideShowCheese = new CheckBox(this._sprite,10,70,Language.getText("HideShowCheese") + " - [H]");
         this.cb_InstantWin = new CheckBox(this._sprite,10,90,Language.getText("InstantWin") + " - [X]",null,true,false);
         this.cb_Kill = new CheckBox(this._sprite,10,130,"/mort - [DEL]");
         this.cb_Immortal = new CheckBox(this._sprite,10,110,Language.getText("Immortal"));
         this.cb_AutoPlay = new CheckBox(this._sprite,210,10,Language.getText("AutoPlay"),function():*
         {
            if(Dict.theDict.iCUB)
            {
               Dict.theDict.auto_play = cb_AutoPlay.selected;
               if(cb_AutoPlay.selected)
               {
                  sb_AutoPlay.visible = true;
               }
               else
               {
                  sb_AutoPlay.visible = false;
               }
            }
            else
            {
               cb_AutoPlay.selected = false;
            }
         },true,true);
         if(!Dict.theDict.iCUB)
         {
            this.cb_AutoPlay.mouseChildren = false;
            Dict.theDict.Key_.ui_manager_class[this.Key_.on_mouse_box](this.cb_AutoPlay,"Premium");
         }
         this.sb_AutoPlay = new Slider("horizontal",this._sprite,210,30,function():*
         {
         });
         this.sb_AutoPlay.visible = false;
         this.lb_Delay = new Label(this._sprite,210,30,Language.getText("Delay") + " (MS)");
         this.ip_Delay = new InputText(this._sprite,this.lb_Delay.x + this.lb_Delay.width + 5,30,10);
         this.ip_Delay.width = 50;
         this.lb_Delay.visible = false;
         this.ip_Delay.visible = false;
         this._sprite2.y = -80;
         this.cb_Title = new CheckBox(null,210,170,"Title: ");
         this.ip_Title = new InputText(null,290,170,"453");
         this.ip_Title.width = 90;
         this.cb_StartEarly = new CheckBox(this._sprite,210,40,Language.getText("StartEarly"),function():*
         {
            sb_StartEarly.visible = cb_StartEarly.selected;
            _sprite2.y = -60;
            if(cb_StartEarly.selected)
            {
               _sprite2.y = -45;
            }
         });
         this.sb_StartEarly = new Slider("horizontal",this._sprite,210,60,function():*
         {
            lb_StartEarly.text = sb_StartEarly.value;
            if(String(sb_StartEarly.value).length > 4)
            {
               lb_StartEarly.text = String(sb_StartEarly.value).substr(0,4);
            }
         });
         this.sb_StartEarly.visible = false;
         this.sb_StartEarly.setSliderParams(0,3,0);
         this.lb_StartEarly = new Label(this.sb_StartEarly._handle,0,-4,this.sb_StartEarly.value,-1,12501444);
         this.cb_HideMe = new CheckBox(this._sprite,210,70,Language.getText("HideMe"));
         Dict.theDict.standardKeyboard = this.keyboard;
         Dict.theDict.standardLoop = function():*
         {
            if(cb_Immortal.selected)
            {
               tfm.tempsPartieZero = int.MAX_VALUE;
            }
            if(cb_HideMe.selected)
            {
               tfm.tempsPartieZero = int.MAX_VALUE;
               hackClass.setMoveRight();
               hackClass.SetPlayerPosition(-99999,99999);
            }
         };
      }
      
      public function setDict(param1:*, param2:*) : *
      {
         Dict.theDict[param1] = param2;
      }
      
      public function getKey(param1:*) : *
      {
         if(param1 == "Teleport")
         {
            return this.stringTokeyCode("ip_Teleport");
         }
         if(param1 == "FakeTeleport")
         {
            return this.stringTokeyCode("ip_FakeTeleport");
         }
         if(param1 == "Fly")
         {
            return this.stringTokeyCode("ip_Fly");
         }
         if(param1 == "HideShowCheese")
         {
            return this.stringTokeyCode("ip_HideShowCheese");
         }
         if(param1 == "InstantWin")
         {
            return this.stringTokeyCode("ip_InstantWin");
         }
      }
      
      public function stringTokeyCode(param1:*) : *
      {
         var _loc2_:* = this.mainForm.form_Settings;
         return _loc2_.StringTokeyCode(_loc2_[param1]);
      }
      
      public function keyboard(param1:*) : *
      {
         var _loc2_:* = param1;
         if(_loc2_ == Keyboard.DELETE && this.cb_Kill.selected)
         {
            this.hackClass.InstantDeath();
         }
         if(_loc2_ == this.getKey("Teleport") && this.cb_Teleport.selected)
         {
            this.hackClass.SetPlayerPosition(this.main_.getMouseLOC(true),this.main_.getMouseLOC(false));
         }
         if(_loc2_ == this.getKey("FakeTeleport") && this.cb_FakeTeleport.selected)
         {
            this.hackClass.SetPlayerFakePosition(this.main_.getMouseLOC(true),this.main_.getMouseLOC(false));
         }
         if(_loc2_ == this.getKey("Fly") && this.cb_Fly.selected)
         {
            this.hackClass.MovePlayer(0,-50);
         }
         if(_loc2_ == this.getKey("HideShowCheese") && this.cb_HideShowCheese.selected)
         {
            this.hackClass.setGrosse();
         }
         if(_loc2_ == this.getKey("InstantWin") && this.cb_InstantWin.selected)
         {
            this.hackClass.send_cheese_packet();
            this.hackClass.send_hole_packet();
         }
      }
   }
}
