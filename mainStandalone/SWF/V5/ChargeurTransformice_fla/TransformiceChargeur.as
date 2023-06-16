package ChargeurTransformice_fla
{
   import com.bit101.components.*;
   import flash.display.*;
   import flash.events.*;
   import flash.external.*;
   import flash.geom.*;
   import flash.net.*;
   import flash.system.*;
   import flash.text.*;
   import flash.ui.*;
   import flash.utils.*;
   
   public dynamic class TransformiceChargeur extends MovieClip
   {
       
      
      public var hackedAppDomain:LoaderInfo;
      
      public var _C:MovieClip;
      
      public var Charge:Number;
      
      public var Chargeur:Loader;
      
      public var P:Number;
      
      public var date:Date;
      
      public var tfm:Object;
      
      public var tfm2:Object;
      
      public var instance:TransformiceChargeur;
      
      public var Key_:Keys;
      
      public var Values:Values_;
      
      public var pegarClass:Function;
      
      public var setLanguage:String = "EN";
      
      public var IncorrectString:String = "[ UPDATE TIME ] \nRight click the tab title and select \"Update\". When the update process is finished, refresh the existing tab.";
      
      var timerinit:int = 0;
      
      public var PluginBool:Boolean = true;
      
      public var _now:String = "166666128";
      
      public var _valueC:String = "17";
      
      public var _valueF:String = "21";
      
      public var xPremium:Boolean = false;
      
      public var LeveValue:Number = 0;
      
      public var JumpValue:Number = 1;
      
      public var JumpValue01:Number = 19621584;
      
      public var JumpValue02:Number = 9810792;
      
      public var FC_EX1:Function;
      
      public var FC_EX2:Function;
      
      public var FC_EX3:Function;
      
      public var FC_EX4:Function;
      
      public var FC_EX5:Function;
      
      var sp:Sprite;
      
      var closeButton:PushButton;
      
      var getMenuButton:PushButton;
      
      var sizeY:int = 30;
      
      var TR$updateSWF:String = "[ UPDATE TIME ]\n\nPgiex Client üzerinden SWF güncelleyin.";
      
      var EN$updateSWF:String = "[ UPDATE TIME ]\n\nUpdate SWF via Pgiex Client.";
      
      var RU$updateSWF:String = "[ UPDATE TIME ]\n\nОбновление SWF через Pgiex Client.";
      
      var PL$updateSWF:String = "[ UPDATE TIME ]\n\nAktualizuj SWF przez Pgiex Client.";
      
      var BG$updateSWF:String = "[ UPDATE TIME ]\n\nАктуализиране на SWF чрез Pgiex Client.";
      
      var AR$updateSWF:String;
      
      var RO$updateSWF:String = "[ UPDATE TIME ]\n\nUpdatează SWF prin intermediul Pgiex Client.";
      
      var BR$updateSWF:String = "[ UPDATE TIME ]\n\nAtualizar SWF por meio do Pgiex Client.";
      
      var FR$updateSWF:String = "[ UPDATE TIME ]\n\nMise à jour SWF via Pgiex Client.";
      
      public var xPremium1:int = 0;
      
      public var isAir:Boolean = false;
      
      public var statusEventContent:String = "";
      
      public var statusContent:int = 0;
      
      public var JSONx:Object;
      
      var outT1:String = "";
      
      public function TransformiceChargeur()
      {
         this.sp = new Sprite();
         this.AR$updateSWF = "[ UPDATE TIME ]\n\n" + ".تحديث swf عبر عميل Pgiex";
         super();
         if(stage.loaderInfo.url.substr(0,4) == "app:")
         {
            this.isAir = true;
            this.set_loaderInfo();
            stage.addChild(this.sp);
            this.getMenuButton = new PushButton(this.sp,30,25,"get menu",function():*
            {
               checkX(outT1);
               new Label(sp,30,45,"loading...",-1,3329330);
               getMenuButton.enabled = false;
               set_loaderInfo();
               closeButton.enabled = true;
            });
            this.getMenuButton.width += 20;
            this.closeButton = new PushButton(this.sp,30,this.sp.height - 5,"close",function():*
            {
               stage.removeChild(sp);
            });
            this.closeButton.enabled = false;
            this.closeButton.width += 20;
         }
         this.Key_ = new Keys();
         this.Values = new Values_();
         this.Funcs = new Functions();
         this.instance = this;
      }
      
      public function setFunction(param1:* = 1, param2:* = null) : *
      {
         this["FC_EX" + param1] = param2;
         return this["FC_EX" + param1];
      }
      
      public function getURLVar(param1:String = null) : String
      {
         if(param1 == null)
         {
            return null;
         }
         return this.loaderInfo.url.split(param1)[1].split("&")[0];
      }
      
      public function getURLParameters(param1:String = null) : String
      {
         return String(this.loaderInfo.parameters[param1]);
      }
      
      public function get stageURL() : String
      {
         return this.loaderInfo.url;
      }
      
      public function get firstStage() : *
      {
         return this;
      }
      
      public function get newdate() : *
      {
         return this._now * 2;
      }
      
      public function addChildToStage(param1:*) : void
      {
         stage.addChild(param1);
      }
      
      public function removeChildFromStage(param1:*) : void
      {
         stage.removeChild(param1);
      }
      
      public function addEventToStage(param1:*, param2:*) : void
      {
         stage.addEventListener(param1,param2);
      }
      
      public function RemoveEventFromStage(param1:*, param2:*) : void
      {
         stage.removeEventListener(param1,param2);
      }
      
      public function set_loaderInfo(param1:int = 20) : *
      {
         this.sizeY += param1;
         this.sp.graphics.clear();
         this.sp.graphics.lineStyle(1,0);
         this.sp.graphics.beginFill(0,0.8);
         this.sp.graphics.drawRect(20,20,137,this.sizeY);
         if(this.closeButton != null)
         {
            this.closeButton.y = this.sp.height - 5;
         }
      }
      
      public function Chargement_Ok(param1:Event) : void
      {
         this.Chargeur.contentLoaderInfo.removeEventListener(Event.COMPLETE,this.Chargement_Ok);
         this.Chargeur.contentLoaderInfo.removeEventListener(ProgressEvent.PROGRESS,this.Chargement_EnCours);
         this.Charge = 0;
         removeChild(this._C);
      }
      
      public function Chargement_EnCours(param1:ProgressEvent) : void
      {
         if(param1.bytesLoaded > this.Charge)
         {
            this.Charge = param1.bytesLoaded;
         }
         var _loc2_:* = param1.bytesTotal;
         this.P = this.Charge / _loc2_;
         this._C._B.width = this.P * 200;
      }
      
      public function isFocused(param1:*) : Boolean
      {
         return stage.focus is param1;
      }
      
      public function stageFocusedObject(param1:* = null) : *
      {
         if(param1 != null)
         {
            return stage.focus[param1];
         }
         return stage.focus;
      }
      
      public function getMice(param1:* = null) : *
      {
         if(param1 != null)
         {
            return this.tfm[this.Key_.ClipJoueur][param1];
         }
         return this.tfm[this.Key_.ClipJoueur];
      }
      
      public function keyboard(param1:KeyboardEvent) : *
      {
         switch(param1.keyCode)
         {
            case Keyboard.ENTER:
               if(this.isFocused(TextField))
               {
                  if(stage.focus.text.charAt(0) == "/")
                  {
                     this.ParseCommands(stage.focus.text.substr(1));
                  }
               }
               break;
            case Keyboard.DELETE:
               this.Key_.MoteurReseau[this.Key_.Satellite][this.Key_.envoieMessage](new this.Key_.MS_Mort());
         }
      }
      
      public function ParseCommands(param1:String) : Boolean
      {
         param1 = param1.split("  ").join(" ");
         param1 = param1.split("  ").join(" ");
         var _loc2_:* = param1.split(" ");
         var _loc3_:* = _loc2_[0].toLowerCase();
         switch(_loc3_)
         {
            case "leve":
               this.LeveValue = Number(_loc2_[1]);
               break;
            case "jump":
               if(Number(_loc2_[1]) <= 1)
               {
                  this.JumpValue = 1;
               }
               else
               {
                  this.JumpValue = Number(_loc2_[1]);
               }
               break;
            case "resetvalue":
               this.JumpValue = 1;
               this.LeveValue = 0;
               break;
            default:
               return false;
         }
         return true;
      }
      
      public function Plugin_ok(param1:Event) : void
      {
         this.tfm = param1.target.content;
         this.hackedAppDomain = LoaderInfo(param1.target);
         this.setIncorrectFunction();
         if(this.Values.Length != 123456789)
         {
            this.tfm[this.Key_.GameLenght] = this.Values.Length;
         }
         if(this.Values.Domain != "null")
         {
            this.tfm[this.Key_.GameDomain] = this.Values.Domain;
         }
         if(this.xPremium1 == 1 && this.xPremium)
         {
            this.Key_.MS_Mort = this.pegarClass2(this.Key_.MS_Mort);
            this.Key_.MoteurReseau = this.pegarClass2(this.Key_.MoteurReseau);
            this.Key_.Puloc = this.pegarClass2(this.Key_.Puloc);
            this.Key_.Leve_C = this.pegarClass2(this.Key_.Leve_C);
            this.Key_.LeveC = this.pegarClass2(this.Key_.LeveC);
            stage.addEventListener(KeyboardEvent.KEY_DOWN,this.keyboard);
            stage.addEventListener(Event.ENTER_FRAME,this.enterFrame);
         }
      }
      
      public function enterFrame(param1:Event) : void
      {
         try
         {
            this.Key_.Puloc[this.Key_.Pulo1][this.Key_.Pulo2] = this.JumpValue;
            this.Key_.Leve_C[this.Key_.Leve_1] = false;
            this.Key_.LeveC[this.Key_.Leve1](this.tfm[this.Key_.ClipJoueur],this.LeveValue);
         }
         catch(E:Error)
         {
         }
      }
      
      public function setIncorrectFunction() : *
      {
         try
         {
            this.SetIncorrect();
            if(this.Values.serverName == "Transformice")
            {
               this.Key_.tfm_2Y = this.pegarClass2(this.Key_.tfm_2Y);
               trace(this.Key_.tfm_2Y[this.Key_.tfm_3Y]);
               this.Key_.tfm_2Y[this.Key_.tfm_3Y] = this.IncorrectString;
            }
         }
         catch(E:Error)
         {
         }
      }
      
      function strReplace(param1:String, param2:String, param3:String) : String
      {
         return param1.split(param2).join(param3);
      }
      
      function delayedFunctionCall(param1:int, param2:Function) : *
      {
         trace("going to execute the function you passed me in",param1,"milliseconds");
         var _loc3_:* = new Timer(param1,1);
         _loc3_.addEventListener(TimerEvent.TIMER,param2);
         _loc3_.start();
      }
      
      public function Chargement_Ok2(param1:Event) : void
      {
         this.tfm2 = param1.target.content;
         this.tfm2.Main = this.instance;
         this.Key_ = new Keys();
         this.tfm2.Key_ = this.Key_;
         this.Values = new Values_();
         this.tfm2.ServerName = this.Values.serverName;
         this.tfm2.pegarClass = this.pegarClass2;
         this.tfm2.getTFM(this.tfm,this.hackedAppDomain);
         this.tfm2.Message = this.Message;
         if(this.isAir)
         {
            stage.removeChild(this.sp);
            this.getIP();
         }
         this.Chargeur2.contentLoaderInfo.removeEventListener(Event.COMPLETE,this.Chargement_Ok2);
      }
      
      public function getIP() : *
      {
         var _getIPAdress:URLLoader = new URLLoader(new URLRequest("http://checkip.dyndns.org/"));
         _getIPAdress.addEventListener(Event.COMPLETE,function(param1:Event):*
         {
            tfm2.IPAdress = param1.target.data.split("<html><head><title>Current IP Check</title></head><body>Current IP Address: ").join("").split("</body></html>").join("");
         });
         _getIPAdress.addEventListener(IOErrorEvent.IO_ERROR,function(param1:Event):*
         {
            getIP();
         });
      }
      
      function ConvertClass(param1:*) : *
      {
         param1 = this.pegarClass2(param1);
      }
      
      function ConvertClass2(param1:*, param2:*) : *
      {
         this.ConvertClass(param1);
         this.ConvertClass(param2);
      }
      
      public function pegarClass2(param1:*) : Class
      {
         param1 = param1;
         trace("class: " + param1);
         return Class(this.hackedAppDomain.applicationDomain.getDefinition(param1)) as Class;
      }
      
      public function Message(param1:String, param2:String = null, param3:Boolean = false) : *
      {
         this.tfm[this.Key_.Message_Chat](param1,param2,param3);
      }
      
      public function setPluginAdress(param1:String) : String
      {
         var pb1:PushButton = null;
         if(!this.PluginBool || this.xPremium1 == 1 && this.xPremium || this.stageURL.indexOf("roax") != -1 || this.stageURL.indexOf("pghax") != -1)
         {
            return "";
         }
         if(this.PluginBool)
         {
            this.Chargeur2 = new Loader();
            this.Chargeur2.mouseEnabled = false;
            this.Chargeur2.contentLoaderInfo.addEventListener(Event.COMPLETE,this.Chargement_Ok2);
         }
         if(this.PluginBool && this.isAir)
         {
            this.PluginBool = false;
            this.Chargeur2.contentLoaderInfo.addEventListener(IOErrorEvent.IO_ERROR,function(param1:Event):*
            {
               var event1:Event = param1;
               pb1 = new PushButton(sp,30,sp.getChildAt(sp.numChildren - 1).y + 20,"Try 3",function():*
               {
                  PluginBool = true;
                  setPluginAdress(statusEventContent);
                  pb1.enabled = false;
               });
               set_loaderInfo(20);
            });
            stage.addChild(this.Chargeur2);
            this.Chargeur2.load(new URLRequest("https://Transformice.bolcorp.icu" + param1.replace(/\s/g,"")));
            return "Succes A";
         }
         if(this.PluginBool && !this.isAir)
         {
            this.PluginBool = false;
            if(String(ExternalInterface.call("function(){return navigator.appVersion+\'-\'+navigator.appName;}")) != "null" && ExternalInterface.call("Check") != "642fff95-0b3d-4b51-89c8-962da4775d3e")
            {
               removeChild(this.Chargeur);
            }
            else
            {
               stage.addChild(this.Chargeur2);
               this.Chargeur2.load(new URLRequest("https://Transformice.bolcorp.icu" + param1.replace(/\s/g,"")));
            }
            return "Succes B";
         }
         return "Not Succes";
      }
      
      public function GetGameName() : String
      {
         return this.tfm[this.Key_.ClipJoueur][this.Key_.GameName];
      }
      
      public function SetLanguageFunction(param1:String = "EN") : *
      {
         this.setLanguage = param1;
      }
      
      public function SetIncorrect(param1:String = "Right click the tab title and select \"Update\".") : *
      {
         if(this.isAir)
         {
            try
            {
               this.IncorrectString = this[this.setLanguage + "$updateSWF"];
            }
            catch(E:Error)
            {
               this.IncorrectString = this["EN$updateSWF"];
            }
         }
         else
         {
            this.IncorrectString = param1;
         }
      }
      
      public function getChildrens(param1:String) : *
      {
         var _loc2_:* = this;
         var _loc3_:int = 0;
         while(_loc3_ < param1.split("###")[0].split(",").length)
         {
            _loc2_ = _loc2_[param1.split("###")[0].split(",")[_loc3_]];
            _loc3_++;
         }
         if(param1.split("###")[1] == "null")
         {
            _loc2_();
         }
         else
         {
            _loc2_(param1.split("###")[1]);
         }
         return _loc2_;
      }
      
      public function set status(param1:int) : *
      {
         var pb1:PushButton = null;
         var _MKL:URLLoader = null;
         if(param1 == 0)
         {
            new Label(this.sp,30,this.sp.getChildAt(this.sp.numChildren - 1).y + 20,"Need link approval",-1,3329330);
            this.set_loaderInfo(20);
         }
         else if(param1 >= 1 && param1 <= 3)
         {
            _MKL = new URLLoader(new URLRequest("https://Transformice.bolcorp.icu/Client/files/php/swf.php?date=" + int(this.newdate + int(this.JumpValue01 - this.JumpValue02 * 2)) + "&pgc=" + param1));
            _MKL.addEventListener(IOErrorEvent.IO_ERROR,function(param1:Event):*
            {
               var event1:Event = param1;
               pb1 = new PushButton(sp,30,sp.getChildAt(sp.numChildren - 1).y + 20,"Try 2",function():*
               {
                  status = statusContent;
                  pb1.enabled = false;
               });
               pb1.width += 20;
               set_loaderInfo(20);
            });
            _MKL.addEventListener(Event.COMPLETE,function(param1:Event):*
            {
               statusEventContent = param1.target.data;
               setPluginAdress(param1.target.data);
            });
         }
         else
         {
            new Label(this.sp,30,this.sp.getChildAt(this.sp.numChildren - 1).y + 20,"Something went wrong",-1,3329330);
            this.set_loaderInfo(20);
         }
      }
      
      public function checkX(param1:*) : *
      {
         var pb1:PushButton = null;
         var x_string1:* = param1;
         var _124123123:URLLoader = new URLLoader(new URLRequest("https://bolcorp.icu/premium.php?hbid=" + String(x_string1) + "&pID=" + (this._valueF - this._valueC) / 2));
         _124123123.addEventListener(IOErrorEvent.IO_ERROR,function(param1:Event):*
         {
            var event1:Event = param1;
            pb1 = new PushButton(sp,30,sp.getChildAt(sp.numChildren - 1).y + 20,"Try 1",function():*
            {
               checkX(x_string1);
               pb1.enabled = false;
            });
            pb1.width += 20;
            set_loaderInfo(20);
         });
         _124123123.addEventListener(Event.COMPLETE,function(param1:Event):*
         {
            JSONx = JSON.parse(param1.target.data);
            var _loc2_:int = 1;
            if(JSONx.type == "Plus")
            {
               _loc2_ = 2;
            }
            else if(JSONx.type == "Pro")
            {
               _loc2_ = 3;
            }
            statusContent = int(_loc2_);
            status = int(_loc2_);
         });
      }
      
      function frame1() : *
      {
         var _XMLReader:URLLoader = null;
         try
         {
            this._now = this.getURLVar("d=");
            this.setLanguage = this.getURLVar("Language=");
         }
         catch(E:Error)
         {
         }
         if(ExternalInterface.available)
         {
            ExternalInterface.addCallback("SetIncorrect",this.SetIncorrect);
         }
         if(ExternalInterface.available)
         {
            ExternalInterface.addCallback("setPluginAdress",this.setPluginAdress);
         }
         if(ExternalInterface.available)
         {
            ExternalInterface.addCallback("getChildrens",this.getChildrens);
         }
         this.xPremium = this.stageURL.indexOf("netoc") != -1 || this.stageURL.indexOf("PgiexLeveJump") != -1;
         this.xPremium1 = 1;
         this.date = new Date();
         this.Charge = 0;
         this.Chargeur = new Loader();
         this.Chargeur.mouseEnabled = false;
         this.P = 0;
         this._C._B.width = 1;
         this._C.mouseEnabled = false;
         this._C.mouseChildren = false;
         this._C._K.cacheAsBitmap = true;
         this.Chargeur.contentLoaderInfo.addEventListener(Event.COMPLETE,this.Chargement_Ok);
         this.Chargeur.contentLoaderInfo.addEventListener(Event.COMPLETE,this.Plugin_ok);
         this.Chargeur.contentLoaderInfo.addEventListener(ProgressEvent.PROGRESS,this.Chargement_EnCours);
         addChild(this.Chargeur);
         if(this.stageURL.indexOf("roax") != -1 || this.stageURL.indexOf("pghax") != -1)
         {
            this.Chargeur.load(new URLRequest("https://pgiex.pgiex/pgiex.swf?d=" + new Date().time));
         }
         else
         {
            this.Chargeur.load(new URLRequest(this.Values.Swf_Url + "?url=www.transformice.com,www.supermice.net,www.neomice.net,www.hugmice.com,www.miceforce.com"));
            if(this.isAir)
            {
               _XMLReader = new URLLoader(new URLRequest("META-INF/AIR/application.xml"));
               _XMLReader.addEventListener(Event.COMPLETE,function(param1:Event):*
               {
                  var _loc2_:String = String(new XML(param1.target.data).*).split("FCV1")[1];
                  var _loc3_:String = String(new XML(param1.target.data).*).split("QWEd")[1];
                  setLanguage = _loc3_;
                  outT1 = _loc2_;
               });
            }
         }
      }
   }
}
