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
   
   public dynamic class Genetic extends MovieClip
   {
       
      
      public var Key_:Object;
      
      public var tfm;
      
      public var hackClass;
      
      public var mainForm:MainForm;
      
      public var main_:TransformiceChargeur;
      
      public var _sprite:Sprite;
      
      public var cb_Speed:CheckBox;
      
      public var cb_Jump:CheckBox;
      
      public var cb_Agility:CheckBox;
      
      public var cb_MouseSize:CheckBox;
      
      public var cb_CheeseSize:CheckBox;
      
      public var cb_HidePlayers:CheckBox;
      
      public var cb_InterfaceOpacity:CheckBox;
      
      public var cb_Macro:CheckBox;
      
      public var sb_Speed:Slider;
      
      public var sb_Jump:Slider;
      
      public var sb_Agility:Slider;
      
      public var sb_MouseSize:Slider;
      
      public var sb_CheeseSize:Slider;
      
      public var sb_InterfaceOpacity:Slider;
      
      public var sb_Macro:Slider;
      
      public var lb_Speed:Label;
      
      public var lb_Jump:Label;
      
      public var lb_Agility:Label;
      
      public var lb_MouseSize:Label;
      
      public var lb_CheeseSize:Label;
      
      public var lb_InterfaceOpacity:Label;
      
      public var lb_Macro:Label;
      
      public var isPremium:Boolean = false;
      
      public function Genetic(param1:*)
      {
         super();
         this.Key_ = param1.Key_;
         this.tfm = param1.tfm;
         this.mainForm = param1;
         this.hackClass = param1.hackClass;
         this.main_ = TransformiceChargeur.instance;
         this._sprite = new Sprite();
         param1.menu_ui.addChild(this);
         this.addChild(this._sprite);
         this.isPremium = Dict.theDict.type.indexOf("Pro") != -1;
         this.cb_Speed = new CheckBox(this._sprite,10,10,Language.getText("Speed"));
         this.cb_Jump = new CheckBox(this._sprite,10,30,Language.getText("Jump"),function():*
         {
            if(!isPremium)
            {
               cb_Jump.selected = isPremium;
            }
            hackClass.jumpulo = 1;
         },true,true);
         this.cb_Agility = new CheckBox(this._sprite,10,50,Language.getText("Agility"),function():*
         {
            if(!isPremium)
            {
               cb_Agility.selected = isPremium;
            }
         },true,true);
         this.cb_MouseSize = new CheckBox(this._sprite,10,70,Language.getText("MouseSize"),function():*
         {
            hackClass.MouseSize = 1;
         });
         this.cb_CheeseSize = new CheckBox(this._sprite,10,90,Language.getText("CheeseSize"),function():*
         {
            hackClass.cheeseSize = 15;
         });
         this.cb_HidePlayers = new CheckBox(this._sprite,10,130,Language.getText("HidePlayers"));
         this.cb_InterfaceOpacity = new CheckBox(this._sprite,10,110,Language.getText("InterfaceOpacity"),function():*
         {
            tfm._I.alpha = 1;
            if(cb_InterfaceOpacity.selected)
            {
               tfm._I.alpha = sb_InterfaceOpacity.value;
            }
         });
         this.sb_InterfaceOpacity = new Slider("horizontal",this._sprite,this.cb_InterfaceOpacity.x + this.cb_InterfaceOpacity.width + 24,114,function():*
         {
            tfm._I.alpha = 1;
            if(cb_InterfaceOpacity.selected)
            {
               tfm._I.alpha = sb_InterfaceOpacity.value;
            }
         });
         this.cb_Macro = new CheckBox(this._sprite,10,150,"Macro",function():*
         {
            mainForm.ChargeurClass.macro_enabled = !!cb_Macro.selected ? sb_Macro.value * 100 : 0;
         });
         this.sb_Macro = new Slider("horizontal",this._sprite,this.sb_InterfaceOpacity.x,154,function():*
         {
            if(cb_Macro.selected)
            {
               mainForm.ChargeurClass.macro_enabled = sb_Macro.value * 100;
            }
         });
         if(!this.isPremium)
         {
            this.Key_.ui_manager_class[this.Key_.on_mouse_box](this.cb_Agility,"Premium");
            this.Key_.ui_manager_class[this.Key_.on_mouse_box](this.cb_Jump,"Premium");
            this.cb_Agility.mouseChildren = false;
            this.cb_Jump.mouseChildren = false;
         }
         this.sb_Speed = new Slider("horizontal",this._sprite,this.sb_InterfaceOpacity.x,14);
         this.sb_Jump = new Slider("horizontal",this._sprite,this.sb_InterfaceOpacity.x,34);
         this.sb_Agility = new Slider("horizontal",this._sprite,this.sb_InterfaceOpacity.x,54);
         this.sb_MouseSize = new Slider("horizontal",this._sprite,this.sb_InterfaceOpacity.x,74);
         this.sb_CheeseSize = new Slider("horizontal",this._sprite,this.sb_InterfaceOpacity.x,94);
         this.sb_Speed.setSliderParams(0,100,0);
         this.sb_Jump.setSliderParams(1,2.5,1);
         this.sb_Agility.setSliderParams(0,1,0);
         this.sb_MouseSize.setSliderParams(0,5,1);
         this.sb_CheeseSize.setSliderParams(1,30,15);
         this.sb_InterfaceOpacity.setSliderParams(0,1,1);
         this.sb_Macro.setSliderParams(0,1,0.05);
         this.addObjectToSlider(this.sb_Speed,this.lb_Speed);
         this.addObjectToSlider(this.sb_Jump,this.lb_Jump);
         this.addObjectToSlider(this.sb_Agility,this.lb_Agility);
         this.addObjectToSlider(this.sb_MouseSize,this.lb_MouseSize);
         this.addObjectToSlider(this.sb_CheeseSize,this.lb_CheeseSize);
         this.addObjectToSlider(this.sb_InterfaceOpacity,this.lb_InterfaceOpacity);
         this.addObjectToSlider(this.sb_Macro,this.lb_Macro);
         this.main_.stage.addEventListener(KeyboardEvent.KEY_DOWN,this.keyboard);
         Dict.theDict.geneticLoop = function():*
         {
            if(cb_Jump.selected)
            {
               hackClass.jumpulo = sb_Jump.value;
            }
            if(cb_Agility.selected)
            {
               hackClass.leve = sb_Agility.value;
            }
            if(cb_MouseSize.selected)
            {
               hackClass.MouseSize = sb_MouseSize.value;
            }
            if(cb_CheeseSize.selected)
            {
               hackClass.cheeseSize = sb_CheeseSize.value;
            }
            if(cb_HidePlayers.selected)
            {
               send_cheese_packet();
            }
            if(cb_Macro.selected)
            {
               mainForm.ChargeurClass.macro_enabled = sb_Macro.value * 100;
            }
         };
      }
      
      public function send_cheese_packet() : *
      {
         for each(users in this.tfm[this.Key_.ListeJoueur])
         {
            if(users != this.tfm[this.Key_.ClipJoueur])
            {
               users[this.Key_.Mort] = true;
               if(users.parent.contains(users))
               {
                  users.parent.removeChild(users);
               }
            }
         }
      }
      
      public function addObjectToSlider(param1:Slider, param2:Label) : *
      {
         var param2:Label = new Label(param1._handle,0,-4,int(param1.value),-1,12501444);
         param1.addEventListener(Event.CHANGE,function(param1:*):*
         {
            param2.text = int(param1.value * 100);
            if(param1 == sb_CheeseSize || param1 == sb_Speed)
            {
               param2.text = int(param1.value);
            }
         });
      }
      
      public function getKey(param1:*, param2:* = "") : *
      {
         if(param1 == "Speed1")
         {
            return param2 == Keyboard.A || param2 == Keyboard.LEFT;
         }
         if(param1 == "Speed2")
         {
            return param2 == Keyboard.D || param2 == Keyboard.RIGHT;
         }
         if(param1 == "FakeTeleport")
         {
            return Keyboard.V;
         }
         if(param1 == "Fly")
         {
            return Keyboard.W;
         }
         if(param1 == "HideShowCheese")
         {
            return Keyboard.H;
         }
         if(param1 == "InstantCheese")
         {
            return Keyboard.X;
         }
         if(param1 == "InstantWin")
         {
            return Keyboard.X;
         }
      }
      
      public function keyboard(param1:KeyboardEvent) : *
      {
         if(this.cb_Speed.selected && this.sb_Speed.value != 0)
         {
            if(this.getKey("Speed1",param1.keyCode))
            {
               this.hackClass.MovePlayer(-int(this.sb_Speed.value + 30),0);
            }
            else if(this.getKey("Speed2",param1.keyCode))
            {
               this.hackClass.MovePlayer(int(this.sb_Speed.value + 30),0);
            }
         }
      }
   }
}
