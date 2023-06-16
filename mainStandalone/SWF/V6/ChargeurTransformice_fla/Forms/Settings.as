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
   
   public dynamic class Settings extends MovieClip
   {
       
      
      public var Key_:Object;
      
      public var tfm;
      
      public var hackClass;
      
      public var mainForm:MainForm;
      
      public var main_:TransformiceChargeur;
      
      public var _sprite:Sprite;
      
      public var ip_Teleport:InputText;
      
      public var ip_FakeTeleport:InputText;
      
      public var ip_Fly:InputText;
      
      public var ip_HideShowCheese:InputText;
      
      public var ip_InstantWin:InputText;
      
      public var ip_Selected:InputText;
      
      public var setY:int = 10;
      
      public var selectedInputText:InputText;
      
      public function Settings(param1:*)
      {
         super();
         this.Key_ = param1;
         this.tfm = param1.tfm;
         this.mainForm = param1;
         this.hackClass = param1.hackClass;
         this.main_ = TransformiceChargeur.instance;
         this._sprite = new Sprite();
         param1.menu_ui.addChild(this);
         this.addChild(this._sprite);
         this.getNewElement("Teleport","ip_Teleport","F");
         this.getNewElement("FakeTeleport","ip_FakeTeleport","V");
         this.getNewElement("Fly","ip_Fly","W");
         this.getNewElement("HideShowCheese","ip_HideShowCheese","H");
         this.getNewElement("InstantWin","ip_InstantWin","X");
      }
      
      public function getNewElement(param1:String, param2:String, param3:String = "") : *
      {
         new Label(this._sprite,10,this.setY,Language.getText(param1));
         this[param2] = new InputText(this._sprite,270,this.setY,param3);
         this.TextboxControl(this[param2],param3,param1);
         this[param2].maxChars = -1;
         this.mainForm.set_shape(this._sprite,10,this.setY + 15,true,370);
         this.setY += 20;
      }
      
      public function TextboxControl(param1:InputText, param2:String, param3:String) : *
      {
         var oldText:String = null;
         var setHackKey:Function = null;
         param1.text = param1.text.toUpperCase();
         oldText = param1.text;
         setHackKey = function(param1:*):*
         {
            param1.text = g_g(param1);
            mainForm.form_Standard["cb_" + param3].label = Language.getText(param3) + " - [" + param1.text + "]";
         };
         param1.addEventListener(MouseEvent.MOUSE_DOWN,function(param1:MouseEvent):*
         {
            selectedInputText = param1;
            if(param1.text.replace(/\s/g,"") != "")
            {
               oldText = param1.text;
            }
            param1.addEventListener(KeyboardEvent.KEY_DOWN,setHackKey);
         });
         param1.addEventListener(MouseEvent.MOUSE_OUT,function(param1:MouseEvent):*
         {
            var event:MouseEvent = param1;
            if(param1.text.replace(/\s/g,"") == "")
            {
               param1.text = oldText;
               setTimeout(function():*
               {
                  param1.textField.selectable = true;
                  param1.textField.setSelection(param1.text.length,param1.text.length);
               },70);
            }
            param1.text = param1.text.toUpperCase();
            param1.removeEventListener(KeyboardEvent.KEY_DOWN,setHackKey);
            stage.focus = stage;
         });
      }
      
      public function g_g(param1:*) : *
      {
         if(param1.keyCode == Keyboard.BACKSPACE || param1.keyCode == Keyboard.ENTER || param1.keyCode == Keyboard.SPACE)
         {
            return;
         }
         var _loc2_:* = String.fromCharCode(param1.charCode).toUpperCase();
         if(_loc2_ >= 0 && _loc2_ <= 9)
         {
            _loc2_ = "NPAD" + _loc2_;
         }
         if(param1.keyCode == Keyboard.BACKQUOTE)
         {
            _loc2_ = "QUOTE";
         }
         if(param1.keyCode == Keyboard.CONTROL)
         {
            _loc2_ = "CTRL";
         }
         if(param1.keyCode == Keyboard.TAB)
         {
            _loc2_ = "TAB";
         }
         if(param1.keyCode == Keyboard.SHIFT)
         {
            _loc2_ = "SHIFT";
         }
         if(param1.keyCode == Keyboard.CAPS_LOCK)
         {
            _loc2_ = "CAPSLOCK";
         }
         if(param1.keyCode == Keyboard.ESCAPE)
         {
            _loc2_ = "ESC";
         }
         if(param1.keyCode == Keyboard.UP)
         {
            _loc2_ = "UP";
         }
         if(param1.keyCode == Keyboard.LEFT)
         {
            _loc2_ = "LEFT";
         }
         if(param1.keyCode == Keyboard.RIGHT)
         {
            _loc2_ = "RIGHT";
         }
         if(param1.keyCode == Keyboard.DOWN)
         {
            _loc2_ = "DOWN";
         }
         if(param1.keyCode == Keyboard.F1)
         {
            _loc2_ = "F1";
         }
         if(param1.keyCode == Keyboard.F2)
         {
            _loc2_ = "F2";
         }
         if(param1.keyCode == Keyboard.F3)
         {
            _loc2_ = "F3";
         }
         if(param1.keyCode == Keyboard.F4)
         {
            _loc2_ = "F4";
         }
         if(param1.keyCode == Keyboard.F5)
         {
            _loc2_ = "F5";
         }
         if(param1.keyCode == Keyboard.F6)
         {
            _loc2_ = "F6";
         }
         if(param1.keyCode == Keyboard.F7)
         {
            _loc2_ = "F7";
         }
         if(param1.keyCode == Keyboard.F8)
         {
            _loc2_ = "F8";
         }
         if(param1.keyCode == Keyboard.F9)
         {
            _loc2_ = "F9";
         }
         return _loc2_;
      }
      
      public function StringTokeyCode(param1:InputText) : int
      {
         var _loc2_:int = 1;
         if(param1.text.substr(0,4) == "NPAD")
         {
            _loc2_ = Keyboard["NUMPAD_" + param1.text.substr(4,1)];
         }
         else if(param1.text == "QUOTE")
         {
            _loc2_ = Keyboard.BACKQUOTE;
         }
         else if(param1.text == "CTRL")
         {
            _loc2_ = Keyboard.CONTROL;
         }
         else if(param1.text == "CAPSLOCK")
         {
            _loc2_ = Keyboard.CAPS_LOCK;
         }
         else if(param1.text == "ESC")
         {
            _loc2_ = Keyboard.ESCAPE;
         }
         else if(Keyboard[param1.text] != "undefined")
         {
            _loc2_ = Keyboard[param1.text];
         }
         else
         {
            _loc2_ = param1.text.charCodeAt(0);
         }
         return _loc2_;
      }
   }
}
