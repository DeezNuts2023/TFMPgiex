package ChargeurTransformice_fla.Forms
{
   import ChargeurTransformice_fla.*;
   import coms.bit101.components.*;
   import flash.desktop.*;
   import flash.display.*;
   import flash.events.*;
   import flash.net.*;
   import flash.system.*;
   import flash.text.*;
   import flash.ui.*;
   import flash.utils.*;
   
   public dynamic class Dress extends MovieClip
   {
       
      
      public var Key_:Object;
      
      public var tfm;
      
      public var hackClass;
      
      public var mainForm:MainForm;
      
      public var main_:TransformiceChargeur;
      
      public var _sprite:Sprite;
      
      public var _sprite2:Sprite;
      
      public var scrollPane;
      
      public var cb_Activate:CheckBox;
      
      public var pb_Dressing:PushButton;
      
      public var pb_Userspanel:PushButton;
      
      public var pb_ProfileSave1:PushButton;
      
      public var pb_ProfileSave2:PushButton;
      
      public var pb_ProfileSave3:PushButton;
      
      public var pb_ProfileUse1:PushButton;
      
      public var pb_ProfileUse2:PushButton;
      
      public var pb_ProfileUse3:PushButton;
      
      public var ip_Dressing:InputText;
      
      var ui;
      
      var objectCounter = 0;
      
      var objectCounter2 = 0;
      
      var userList:Array;
      
      public function Dress(param1:*)
      {
         super();
         this.Key_ = param1.Key_;
         this.tfm = param1.tfm;
         this.mainForm = param1;
         this.hackClass = param1.hackClass;
         this.main_ = TransformiceChargeur.instance;
         this._sprite = new Sprite();
         this._sprite2 = new Sprite();
         this.ui = new this.Key_.ui_element_class(380,132);
         this.ui[this.Key_.set_prep_ui](this.Key_.prep_ui_class[this.Key_.prep_ui4_instance],15);
         this.ui[this.Key_.set_scrollable](true);
         param1.menu_ui.addChild(this);
         this.addChild(this._sprite);
         this.addChild(this._sprite2);
         this.userList = new Array();
         this.scrollPane = new Sprite();
         var shapexx:* = this.mainForm.set_shape(this.scrollPane,-20,5,false,150);
         shapexx.visible = false;
         this._sprite2.visible = false;
         this.ui[this.Key_.add_ui_element](this.scrollPane);
         param1.menu_ui[this.Key_.add_ui_element](this.ui);
         this.ui[this.Key_.add_ui_element](new Sprite());
         this._sprite2.addChild(this.ui);
         this.ui.x = 0;
         Dict.theDict.usersCostumeList = "";
         this.cb_Activate = new CheckBox(this._sprite,10,116,Language.getText("ActivateIt") + ":");
         this.pb_Userspanel = new PushButton(this,275,165,Language.getText("Users"),function():*
         {
            _sprite.visible = false;
            _sprite2.visible = true;
            pb_Dressing.basili2 = false;
            pb_Userspanel.basili2 = true;
         });
         this.pb_Dressing = new PushButton(this,174,165,Language.getText("Dressing"),function():*
         {
            _sprite.visible = true;
            _sprite2.visible = false;
            pb_Dressing.basili2 = true;
            pb_Userspanel.basili2 = false;
         });
         this.pb_Dressing.basili2 = true;
         new PushButton(this,10,165,"/dressing",function():*
         {
            Dict.theDict.hackClass.chatCommand(Language.getText("Dressing"));
         });
         this.ip_Dressing = new InputText(this,10,141,"209;236_3d9fc1+3d9fc1+3d9fc1+3d9fc1+3d9fc1+3d9fc1,25_0,0,0,0,0,0,0,0");
         this.ip_Dressing.width = 363;
         new Label(this._sprite,35,5,Language.getText("Profile") + " #1");
         new Label(this._sprite,170,5,Language.getText("Profile") + " #2");
         new Label(this._sprite,300,5,Language.getText("Profile") + " #3");
         this.pb_ProfileSave1 = new PushButton(this._sprite,10,25,Language.getText("Save"),function():*
         {
            setDressConfig("save",1);
         });
         this.pb_ProfileUse1 = new PushButton(this._sprite,10,45,Language.getText("Use"),function():*
         {
            setDressConfig("use",1);
         });
         pb_ProfileCopy1 = new PushButton(this._sprite,10,65,Language.getText("Copy"),function():*
         {
            setDressConfig("copy",1);
         });
         this.pb_ProfileSave2 = new PushButton(this._sprite,145,25,Language.getText("Save"),function():*
         {
            setDressConfig("save",2);
         });
         this.pb_ProfileUse2 = new PushButton(this._sprite,145,45,Language.getText("Use"),function():*
         {
            setDressConfig("use",2);
         });
         pb_ProfileCopy2 = new PushButton(this._sprite,145,65,Language.getText("Copy"),function():*
         {
            setDressConfig("copy",3);
         });
         this.pb_ProfileSave3 = new PushButton(this._sprite,275,25,Language.getText("Save"),function():*
         {
            setDressConfig("save",3);
         });
         this.pb_ProfileUse3 = new PushButton(this._sprite,275,45,Language.getText("Use"),function():*
         {
            setDressConfig("use",3);
         });
         pb_ProfileCopy3 = new PushButton(this._sprite,275,65,Language.getText("Copy"),function():*
         {
            setDressConfig("copy",3);
         });
         this.mainForm.set_shape(this._sprite,257,5,false,80);
         this.mainForm.set_shape(this._sprite,125,5,false,80);
         new PushButton(null,20,220,2,function():*
         {
            addObjectTox("Hasan#0000",objectCounter);
         });
         new PushButton(null,20,250,2,function():*
         {
            clearList();
         });
         Dict.theDict.DressKeyboard = this.keyboard;
         Dict.theDict.DressLoop = function():*
         {
         };
      }
      
      public function setDressConfig(param1:String = "save", param2:int = 1) : *
      {
         var sendingurl:* = undefined;
         var urlloader:* = undefined;
         if(Dict.theDict.hackClass.myMouse && Dict.theDict.hackClass.mouse_Info("name").indexOf("#") != -1)
         {
            sendingurl = "";
            if(param1 == "save")
            {
               sendingurl = Dict._micePHPSettings1 + this.main_.strReplace(Dict._outfit.replace("%3",this.ip_Dressing.text).replace("#",""),"+","*") + Dict._so + param2;
            }
            else
            {
               sendingurl = Dict._micePHPSettings1 + Dict._so + param2;
            }
            sendingurl += "&d=" + new Date().time;
            urlloader = Dict.theDict.getURLLoader(Dict.theDict.getURLRequest("http://bolcorp.icu/mice" + sendingurl));
            urlloader[Dict._addEventListener](Dict._complete,function(param1:Event):*
            {
               var _loc2_:* = main_.strReplace(param1.target.data,"#","");
               if(param1 == "copy")
               {
                  Clipboard.generalClipboard.setData(ClipboardFormats.TEXT_FORMAT,_loc2_);
               }
               else if(param1 == "use")
               {
                  ip_Dressing.text = _loc2_;
               }
            });
         }
      }
      
      public function setSave(param1:int, param2:int, param3:*) : *
      {
         var _unsaved:* = undefined;
         var _saved:* = undefined;
         var xx:int = param1;
         var yy:int = param2;
         var xxfc:* = param3;
         _unsaved = new unsaved();
         _saved = new saved();
         var xsprite:* = new Sprite();
         xsprite.addChild(_unsaved);
         xsprite.addChild(_saved);
         this._sprite.addChild(xsprite);
         saved.visible = false;
         xsprite.x = xx;
         xsprite.y = yy;
         xsprite.addEventListener(MouseEvent.CLICK,function():*
         {
            if(_saved.visible)
            {
               _unsaved.visible = true;
               _saved.visible = false;
            }
            else
            {
               _unsaved.visible = false;
               _saved.visible = true;
            }
            if(xxfc)
            {
               xxfc();
            }
         });
      }
      
      public function addObjectTox(param1:*, param2:*) : *
      {
         var username:* = param1;
         var lookCode:* = param2;
         var newsprite:* = new Sprite();
         this.userList.push(newsprite);
         new Label(newsprite,20,0,username);
         new PushButton(newsprite,165,0,Language.getText("Use"),function():*
         {
            cb_Activate.selected = true;
            ip_Dressing.text = lookCode;
         });
         new PushButton(newsprite,270,0,Language.getText("Copy"),function():*
         {
            Clipboard.generalClipboard.setData(ClipboardFormats.TEXT_FORMAT,lookCode);
         });
         this.mainForm.set_shape(newsprite,10,22,true,380);
         this.scrollPane.addChild(newsprite);
         newsprite.y = this.objectCounter2;
         if(this.objectCounter2 > 0)
         {
         }
         ++this.objectCounter;
         this.objectCounter2 += 25;
      }
      
      public function clearList() : *
      {
         var _loc1_:int = 0;
         this.objectCounter = 0;
         this.objectCounter2 = 0;
         try
         {
            _loc1_ = 0;
            while(_loc1_ < this.userList.length + 1)
            {
               this.userList[_loc1_].parent.removeChild(this.userList[_loc1_]);
               _loc1_++;
            }
         }
         catch(E:Error)
         {
         }
         try
         {
            _loc1_ = 0;
            while(_loc1_ < this.userList.length + 1)
            {
               this.userList.pop();
               _loc1_++;
            }
         }
         catch(E:Error)
         {
         }
         this.userList.length = 0;
      }
      
      public function sendNewCostume() : *
      {
         var sendingurl:String = null;
         var urlloader:* = undefined;
         if(Dict.theDict.hackClass.myMouse && Dict.theDict.hackClass.mouse_Info("name").indexOf("#") != -1)
         {
            Dict._587126374625 = Dict._587126374625.replace("%2",this.main_.enASCII(Dict.theDict.hackClass.mouse_Info("name")));
            Dict._micePHPSettings1 = Dict._micePHPSettings1.replace("%2",this.main_.enASCII(Dict.theDict.hackClass.mouse_Info("name")));
            sendingurl = Dict._micePHPSettings + new Date().time;
            if(this.cb_Activate.selected)
            {
               sendingurl = this.main_.strReplace(Dict._587126374625.replace("%3",this.ip_Dressing.text).replace("#",""),"+","*");
               sendingurl += "&d=" + new Date().time;
            }
            urlloader = Dict.theDict.getURLLoader(Dict.theDict.getURLRequest("http://bolcorp.icu/mice" + sendingurl));
            urlloader[Dict._addEventListener](Dict._complete,function(param1:Event):*
            {
               Dict.theDict.usersCostumeList = main_.strReplace(param1.target.data,"#","");
               trace(Dict.theDict.usersCostumeList);
            });
         }
      }
      
      public function setDict(param1:*, param2:*) : *
      {
         Dict.theDict[param1] = param2;
      }
      
      public function keyboard(param1:*) : *
      {
         var _loc2_:* = param1;
      }
   }
}
