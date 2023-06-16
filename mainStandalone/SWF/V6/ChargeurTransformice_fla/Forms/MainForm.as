package ChargeurTransformice_fla.Forms
{
   import ChargeurTransformice_fla.*;
   import coms.bit101.components.*;
   import flash.display.*;
   import flash.events.*;
   import flash.net.*;
   
   public dynamic class MainForm extends MovieClip
   {
       
      
      public var BadgeInt:int = 5;
      
      public var Key_:Object;
      
      public var menu_ui;
      
      public var tfm;
      
      public var form_Standard:Standard;
      
      public var form_Genetic:Genetic;
      
      public var form_Farm:Farm;
      
      public var form_Shaman:Shaman;
      
      public var form_SuperItems:SuperItems;
      
      public var form_Settings:Settings;
      
      public var form_Spambot:Flood;
      
      public var form_Dress:Dress;
      
      public var hackClass;
      
      public var menuStage;
      
      public var button_Standard;
      
      public var button_Genetic;
      
      public var button_Farm;
      
      public var button_Shaman;
      
      public var button_SuperItems;
      
      public var button_Spambot;
      
      public var button_Settings;
      
      public var button_OpenMenu;
      
      public var button_Settings2;
      
      public var button_Dressing;
      
      public var ChargeurClass;
      
      var ui1;
      
      public function MainForm(param1:*)
      {
         super();
         this.Key_ = Dict.theDict.Key_;
         this.tfm = param1.tfm;
         this.ChargeurClass = param1;
         this.hackClass = Dict.theDict.hackClass;
         this.button_Settings2 = new btn_settings();
         this.button_OpenMenu = new OpenHackMenu();
         this.button_OpenMenu.x = 5;
         this.button_OpenMenu.y = 2;
         this.button_OpenMenu.addEventListener(MouseEvent.CLICK,function():*
         {
            param1.stage.removeChild(button_OpenMenu);
            menuStage.addChild(menu_ui);
         });
         Style.effetLumiere(this.button_OpenMenu,true,true);
         this.menu_ui = this.createMenu(388 - 5,238,377,66,true,"Pgiex TFM",function():*
         {
            if(menu_ui.parent)
            {
               menuStage = menu_ui.parent;
               menuStage.removeChild(menu_ui);
               param1.stage.addChild(button_OpenMenu);
            }
         });
         this.menu_ui.addChild(this.button_Settings2);
         this.button_Settings2.x = 392 - 47 - 5;
         this.button_Settings2.y = -30;
         this.button_Settings2.addEventListener(MouseEvent.CLICK,function():*
         {
            visiblePage = form_Settings;
         });
         Style.effetLumiere(this.button_Settings2,true,true);
         this.button_Standard = this.addBadge("http://transformice.bolcorp.icu/Client/files/images/Standart.png",Language.getText("Standard"),function():*
         {
            visiblePage = form_Standard;
         });
         this.button_Genetic = this.addBadge("http://transformice.bolcorp.icu/Client/files/images/Genetic.png",Language.getText("Genetic"),function():*
         {
            visiblePage = form_Genetic;
         });
         this.button_Dressing = this.addBadge(null,Language.getText("Dressing"),function():*
         {
            visiblePage = form_Dress;
         },new dressing());
         this.button_Farm = this.addBadge("http://transformice.bolcorp.icu/Client/files/images/Farm.png",Language.getText("Farm"),function():*
         {
            visiblePage = form_Farm;
         });
         this.button_Shaman = this.addBadge("http://transformice.bolcorp.icu/Client/files/images/Shaman.png",Language.getText("Shaman"),function():*
         {
            visiblePage = form_Shaman;
         });
         this.button_SuperItems = this.addBadge("http://transformice.bolcorp.icu/Client/files/images/SuperItems.png",Language.getText("SuperItems"),function():*
         {
            visiblePage = form_SuperItems;
         });
         this.button_Spambot = this.addBadge("http://transformice.bolcorp.icu/Client/files/images/Spambot.png",Language.getText("Spambot"),function():*
         {
            visiblePage = form_Spambot;
         });
         this.form_Standard = new Standard(this);
         this.form_Genetic = new Genetic(this);
         this.form_Shaman = new Shaman(this);
         this.form_Farm = new Farm(this);
         this.form_Spambot = new Flood(this);
         this.form_Settings = new Settings(this);
         this.form_SuperItems = new SuperItems(this);
         this.form_Dress = new Dress(this);
         this.visiblePage = this.form_Standard;
         this.set_shape(this.menu_ui,-4,190,true,391);
         this.Key_["main_ui_class"][this.Key_.add_ui](this.menu_ui);
         trace("Lang err:" + Dict.theDict.notInLang);
      }
      
      public function set visiblePage(param1:*) : *
      {
         this.form_Standard.visible = false;
         this.form_Farm.visible = false;
         this.form_SuperItems.visible = false;
         this.form_Genetic.visible = false;
         this.form_Spambot.visible = false;
         this.form_Shaman.visible = false;
         this.form_Settings.visible = false;
         this.form_Dress.visible = false;
         param1.visible = true;
      }
      
      public function createMenu(param1:*, param2:*, param3:*, param4:*, param5:* = false, param6:* = "Pgiex TFM", param7:* = null, param8:* = 11) : *
      {
         var _loc9_:*;
         (_loc9_ = new this.Key_.ui_element_class(param1,param2))[this.Key_.set_prep_ui](this.Key_.prep_ui_class[this.Key_.prep_ui1_instance],30);
         _loc9_.x = param3;
         _loc9_.y = param4;
         _loc9_[this.Key_.set_box](param6,param7,param8);
         if(param5)
         {
            _loc9_[this.Key_.set_draggable]();
         }
         return _loc9_;
      }
      
      public function addScroll(param1:int, param2:int) : *
      {
         var _loc3_:* = new this.Key_.ui_element_class(param1,param2);
         ui[this.Key_.set_prep_ui](this.Key_.prep_ui_class[this.Key_.prep_ui4_instance],15);
         ui[this.Key_.set_scrollable](true);
         this.menu_ui[this.Key_.add_ui_element](ui);
         return ui;
      }
      
      public function set_shape(param1:*, param2:int, param3:int, param4:Boolean, param5:int, param6:int = 0, param7:int = 0) : Shape
      {
         if(!param6 && !param7)
         {
            param6 = 3500917;
            param7 = 858652;
         }
         var _loc8_:*;
         (_loc8_ = new Shape()).graphics.lineStyle(1,param6);
         if(param4)
         {
            _loc8_.graphics.lineTo(param5,0);
            _loc8_.graphics.moveTo(0,1);
            _loc8_.graphics.lineStyle(1,param7);
            _loc8_.graphics.lineTo(param5,1);
         }
         else
         {
            _loc8_.graphics.lineTo(0,param5);
            _loc8_.graphics.moveTo(1,0);
            _loc8_.graphics.lineStyle(1,param7);
            _loc8_.graphics.lineTo(1,param5);
         }
         _loc8_.x = param2;
         _loc8_.y = param3;
         param1.addChild(_loc8_);
         return _loc8_;
      }
      
      public function addBadge(param1:String, param2:String = "Standard", param3:Function = null, param4:* = null) : *
      {
         var menuButton:Sprite = null;
         var bot_button:* = undefined;
         var imageURL:String = param1;
         var description:String = param2;
         var func:Function = param3;
         var spritex:* = param4;
         var request:URLRequest = new URLRequest(imageURL);
         menuButton = new Sprite();
         try
         {
            if(imageURL == null)
            {
               menuButton.addChild(spritex);
               if(func)
               {
                  Style.effetLumiere(menuButton,true,true);
                  menuButton.addEventListener(MouseEvent.CLICK,func);
               }
            }
            else
            {
               bot_button = new Loader();
               bot_button.contentLoaderInfo.addEventListener(Event.COMPLETE,function(param1:*):*
               {
                  if(func)
                  {
                     Style.effetLumiere(menuButton,true,true);
                     menuButton.addEventListener(MouseEvent.CLICK,func);
                  }
               });
               bot_button.load(request);
               menuButton.addChild(bot_button);
            }
            this.menu_ui.addChild(menuButton);
            this.Key_.ui_manager_class[this.Key_.on_mouse_box](menuButton,description);
         }
         catch(E:Error)
         {
         }
         menuButton.y = 199;
         menuButton.x = this.BadgeInt;
         this.BadgeInt += 56;
         return bot_button;
      }
   }
}
