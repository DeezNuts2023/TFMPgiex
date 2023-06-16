package ChargeurTransformice_fla
{
   import ChargeurTransformice_fla.Forms.*;
   import coms.adobe.serialization.json.*;
   import coms.bit101.components.*;
   import flash.desktop.*;
   import flash.display.*;
   import flash.events.*;
   import flash.geom.*;
   import flash.media.*;
   import flash.net.*;
   import flash.system.*;
   import flash.text.*;
   import flash.ui.*;
   import flash.utils.*;
   
   public dynamic class TransformiceChargeur extends MovieClip
   {
      
      public static var instance:TransformiceChargeur;
      
      private static const _decodeChars:Vector.<int> = _initDecodeChar();
      
      private static const _encodeChars:Vector.<int> = _initEncoreChar();
       
      
      public var hackedAppDomain:LoaderInfo;
      
      public var _C:MovieClip;
      
      public var Charge:Number;
      
      public var Chargeur:Loader;
      
      public var P:Number;
      
      public var date:Date;
      
      public var tfm:Object;
      
      public var tfm2:Object;
      
      public var serverName:String = "Transformice";
      
      public var setLanguage:String = "EN";
      
      public var maps;
      
      public var last_bulle_socket_instance:Object;
      
      public var last_main_socket_instance:Object;
      
      public var IncorrectString:String = "[ UPDATE TIME ] \nRight click the tab title and select \"Update\". When the update process is finished, refresh the existing tab.";
      
      var timerinit:int = 0;
      
      public var PluginBool:Boolean;
      
      public var isAir:Boolean;
      
      public var send_bulle;
      
      public var Sound_NP:Sound;
      
      public var roomList:Array;
      
      public var _623423_jgOJx:int = 0;
      
      public var gameByte_KEY = "1515378475635";
      
      public var gameDomain_KEY:Object = "8171886644";
      
      public var macro:Boolean = false;
      
      public var macro_enabled:Number = 0;
      
      var _512342131:int = 0;
      
      var _512342132:int = 0;
      
      var _512342133:int = 0;
      
      public var isIn:Boolean = false;
      
      public var JSONx:Object;
      
      public var CreatedkeyList:Boolean = false;
      
      public function TransformiceChargeur()
      {
         this.maps = new Array();
         this.PluginBool = Dict._true;
         this.isAir = Dict._false;
         this.roomList = new Array();
         super();
         this.isAir = this.stageURL.substr(0,4) == Dict._8456784567;
         instance = this;
      }
      
      public static function encode(param1:String) : String
      {
         var _loc2_:ByteArray = new ByteArray();
         _loc2_.writeUTFBytes(param1);
         return encodeByteArray(_loc2_);
      }
      
      public static function decode(param1:String) : String
      {
         var _loc2_:ByteArray = decodeToByteArray(param1);
         return _loc2_.readUTFBytes(_loc2_.length);
      }
      
      public static function encodeByteArray(param1:ByteArray) : String
      {
         var _loc6_:uint = 0;
         var _loc2_:ByteArray = new ByteArray();
         _loc2_.length = (2 + param1.length - (param1.length + 2) % 3) * 4 / 3;
         var _loc3_:int = 0;
         var _loc4_:int = param1.length % 3;
         var _loc5_:int = param1.length - _loc4_;
         var _loc7_:int = 0;
         while(_loc3_ < _loc5_)
         {
            _loc6_ = param1[int(_loc3_++)] << 16 | param1[int(_loc3_++)] << 8 | param1[int(_loc3_++)];
            _loc2_[int(_loc7_++)] = _encodeChars[int(_loc6_ >>> 18)];
            _loc2_[int(_loc7_++)] = _encodeChars[int(_loc6_ >>> 12 & 63)];
            _loc2_[int(_loc7_++)] = _encodeChars[int(_loc6_ >>> 6 & 63)];
            _loc2_[int(_loc7_++)] = _encodeChars[int(_loc6_ & 63)];
         }
         if(_loc4_ == 1)
         {
            _loc6_ = param1[int(_loc3_)];
            _loc2_[int(_loc7_++)] = _encodeChars[int(_loc6_ >>> 2)];
            _loc2_[int(_loc7_++)] = _encodeChars[int((_loc6_ & 3) << 4)];
            _loc2_[int(_loc7_++)] = 61;
            _loc2_[int(_loc7_++)] = 61;
         }
         else if(_loc4_ == 2)
         {
            _loc6_ = param1[int(_loc3_++)] << 8 | param1[int(_loc3_)];
            _loc2_[int(_loc7_++)] = _encodeChars[int(_loc6_ >>> 10)];
            _loc2_[int(_loc7_++)] = _encodeChars[int(_loc6_ >>> 4 & 63)];
            _loc2_[int(_loc7_++)] = _encodeChars[int((_loc6_ & 15) << 2)];
            _loc2_[int(_loc7_++)] = 61;
         }
         return _loc2_.readUTFBytes(_loc2_.length);
      }
      
      public static function decodeToByteArrayB(param1:String) : ByteArray
      {
         return decodeToByteArray(param1);
      }
      
      private static function _initEncoreChar() : Vector.<int>
      {
         var _loc1_:Vector.<int> = new Vector.<int>(64,true);
         var _loc2_:String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
         var _loc3_:int = 0;
         while(_loc3_ < 64)
         {
            _loc1_[_loc3_] = _loc2_.charCodeAt(_loc3_);
            _loc3_++;
         }
         return _loc1_;
      }
      
      private static function _initDecodeChar() : Vector.<int>
      {
         return new <int>[-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,62,-1,-1,-1,63,52,53,54,55,56,57,58,59,60,61,-1,-1,-1,-1,-1,-1,-1,0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,-1,-1,-1,-1,-1,-1,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1];
      }
      
      public static function decodeToByteArray(param1:String) : ByteArray
      {
         var _loc2_:int = 0;
         var _loc3_:int = 0;
         var _loc4_:int = 0;
         var _loc5_:int = 0;
         var _loc6_:int = 0;
         var _loc9_:int = 0;
         var _loc7_:int = param1.length;
         var _loc8_:ByteArray;
         (_loc8_ = new ByteArray())[Dict._writeUTFBytes](param1);
         while(_loc6_ < _loc7_)
         {
            _loc2_ = _decodeChars[int(_loc8_[_loc6_++])];
            if(_loc2_ == -1)
            {
               break;
            }
            _loc3_ = _decodeChars[int(_loc8_[_loc6_++])];
            if(_loc3_ == -1)
            {
               break;
            }
            _loc8_[int(_loc9_++)] = _loc2_ << 2 | (_loc3_ & 48) >> 4;
            if((_loc4_ = _loc8_[int(_loc6_++)]) == 61)
            {
               break;
            }
            if((_loc4_ = _decodeChars[int(_loc4_)]) == -1)
            {
               break;
            }
            _loc8_[int(_loc9_++)] = (_loc3_ & 15) << 4 | (_loc4_ & 60) >> 2;
            if((_loc5_ = _loc8_[int(_loc6_++)]) == 61)
            {
               break;
            }
            if((_loc5_ = _decodeChars[int(_loc5_)]) == -1)
            {
               break;
            }
            _loc8_[int(_loc9_++)] = (_loc4_ & 3) << 6 | _loc5_;
         }
         _loc8_.length = _loc9_;
         _loc8_[Dict._position] = 0;
         return _loc8_;
      }
      
      public function getEncrypt_zlib(param1:*) : *
      {
         var _loc2_:* = new ByteArray();
         _loc2_.writeUTFBytes(param1);
         _loc2_.compress("zlib");
         _loc2_.position = 0;
         var _loc3_:ByteArray = new ByteArray();
         _loc2_.readBytes(_loc3_,0,_loc2_.length);
         return _loc3_.readUTFBytes(_loc3_.length);
      }
      
      public function enASCII(param1:String) : *
      {
         return param1.replace("#","23");
      }
      
      public function get _Dict() : Dictionary
      {
         return Dict.theDict;
      }
      
      public function setDict(param1:*) : *
      {
         this._Dict[param1] = this[param1];
      }
      
      public function getURLParameters(param1:String = null) : String
      {
         return String(loaderInfo[Dict._parameters][param1]);
      }
      
      public function get stageURL() : String
      {
         return this.firstStage[Dict._loaderInfo][Dict._url];
      }
      
      public function get firstStage() : *
      {
         return this;
      }
      
      public function Chargement_Ok(param1:Event) : void
      {
         this.Chargeur[Dict._contentLoaderInfo][Dict._removeEventListener](Dict._complete,this.Chargement_Ok);
         this.Chargeur[Dict._contentLoaderInfo][Dict._removeEventListener](Dict._progress,this.Chargement_EnCours);
         this.Charge = 0;
         removeChild(this._C);
      }
      
      public function disable_auto_play() : void
      {
         try
         {
            clearTimeout(this._Dict.current_timeout);
            this._Dict.current_timeout = Dict.int_0 - 1;
            stage[Dict._removeEventListener](Dict._enterFrame,this.PlayRecord);
         }
         catch(e:Error)
         {
         }
      }
      
      public function close_main_socket(param1:Event) : void
      {
         this.close_socket(param1,this.main_socket_data,this.close_main_socket);
      }
      
      public function close_bulle_socket(param1:Event) : void
      {
         this.close_socket(param1,this.bulle_socket_data,this.close_bulle_socket);
      }
      
      public function close_socket(param1:Event, param2:Function, param3:Function) : void
      {
         param1[Dict._currentTarget][Dict._removeEventListener](Dict._socketData,param2);
         param1[Dict._currentTarget][Dict._removeEventListener](Dict._close,param3);
      }
      
      public function player_respawn() : void
      {
         _local1 = this._Dict["getByteArray"]();
         _local1[Dict._writeBytes](this.PlayerData());
         _local1[Dict._writeBoolean](Dict._false);
         _local1[Dict._writeBoolean](Dict._true);
         this.ParsePacket(Dict.int_144,Dict.int_2,_local1);
      }
      
      public function PlayerData(param1:Boolean = false) : *
      {
         var _loc2_:* = this._Dict["getByteArray"]();
         _loc2_[Dict._writeUTF](this._Dict.playerName);
         _loc2_[Dict._writeInt](this._Dict.playerCode);
         _loc2_[Dict._writeBoolean](true);
         _loc2_[Dict._writeBoolean](param1);
         _loc2_[Dict._writeShort](this._Dict.playerScore);
         _loc2_[Dict._writeBoolean](this._Dict.hasCheese);
         _loc2_[Dict._writeShort](!!this._Dict.mainForm.form_Standard.cb_Title.selected ? int(this._Dict.mainForm.form_Standard.ip_Title[Dict._text]) : this._Dict.playerTitle);
         _loc2_[Dict._writeByte](Dict.int_0);
         _loc2_[Dict._writeByte](Dict.int_0);
         _loc2_[Dict._writeUTF]("");
         _loc2_[Dict._writeUTF](!!this._Dict.mainForm.form_Dress.cb_Activate.selected ? this._Dict.mainForm.form_Dress.ip_Dressing[Dict._text] : this._Dict.playerLook);
         _loc2_[Dict._writeBoolean](Dict._false);
         _loc2_[Dict._writeInt](Dict.int_7886906);
         _loc2_[Dict._writeInt](Dict.int_9820630);
         _loc2_[Dict._writeInt](Dict.int_0);
         _loc2_[Dict._writeInt](Dict.int_0 - 1);
         return _loc2_;
      }
      
      public function onReceive(param1:ByteArray, param2:String) : void
      {
         var _loc7_:* = undefined;
         var _loc8_:* = undefined;
         _local3 = this._Dict["getByteArray"]();
         _local3[Dict._writeObject](param1);
         _local3[Dict._position] = Dict.int_0;
         var _loc3_:ByteArray = _local3[Dict._readObject]();
         var _loc4_:uint = _loc3_[Dict._readUnsignedByte]();
         var _loc5_:uint = _loc3_[Dict._readUnsignedByte]();
         var _loc6_:* = Dict._true;
         if(_loc4_ == Dict.int_5 && _loc5_ == Dict.int_2)
         {
            this._Dict.mainForm.form_Dress.sendNewCostume();
            this._Dict.disable_auto_play();
            this._Dict.map_code_int = _loc3_[Dict._readInt]();
            this._Dict.map_code = Dict._et + this._Dict.map_code_int;
            this._Dict.miceLength = _loc3_[Dict._readShort]();
            this._Dict.round_code = _loc3_[Dict._readByte]();
            _local20 = _loc3_[Dict._readInt]();
            _local21 = "";
            if(this._Dict.sendRoomInformation)
            {
               this.sendChatMessage(Dict._roomInformation.replace("%1",this._Dict.map_code).replace("%2",this._Dict.miceLength));
            }
            if(_local20)
            {
               _local3 = new ByteArray();
               _loc3_[Dict._readBytes](_local3,Dict.int_0,_local20);
               _local3[Dict._uncompress](Dict._zlib);
               _local3[Dict._position] = 0;
               _local21 = _local3[Dict._readUTFBytes](_local3.length);
            }
            this._Dict.current_map_xml = _local21;
            _loc3_[Dict._readUTF]();
            _loc3_[Dict._readByte]();
            this._Dict.reverse_map = _loc3_[Dict._readBoolean]();
            if(this._Dict.auto_play)
            {
               stage[Dict._addEventListener](Dict._enterFrame,this.PlayRecord);
            }
         }
         if(_loc4_ == Dict.int_26 && _loc5_ == Dict.int_2)
         {
            _local14 = this._Dict["getByteArray"]();
            this._Dict.playerID = _loc3_[Dict._readInt]();
            this._Dict.playerName = _loc3_[Dict._readUTF]();
            _local14[Dict._writeInt](this._Dict.playerID);
            _local14[Dict._writeUTF](this._Dict.playerName);
            _local14[Dict._writeInt](_loc3_[Dict._readInt]());
            _local14[Dict._writeByte](_loc3_[Dict._readByte]());
            this._Dict.playerCode = _loc3_[Dict._readInt]();
            _local14[Dict._writeInt](this._Dict.playerCode);
            _local14[Dict._writeByte](Dict.int_1);
            _local14[Dict._writeByte](Dict.int_13);
            _local14[Dict._writeByte](Dict.int_0 - 1);
            _local14[Dict._writeByte](Dict.int_10 + 3);
            _local14[Dict._writeByte](Dict.int_10 + 3);
            _local14[Dict._writeByte](Dict.int_5);
            _local14[Dict._writeByte](Dict.int_0 - 1);
            _local14[Dict._writeByte](Dict.int_13);
            _local14[Dict._writeByte](Dict.int_15);
            _local14[Dict._writeByte](Dict.int_11);
            _local14[Dict._writeByte](Dict.int_5);
            _local14[Dict._writeByte](Dict.int_5);
            _local14[Dict._writeByte](Dict.int_5);
            _local14[Dict._writeByte](Dict.int_10);
            _local14[Dict._writeByte](Dict.int_10);
            _local14[Dict._writeByte](Dict.int_0);
            _local14[Dict._writeShort](225);
            _local14[Dict._writeShort](Dict.int_0);
            this._Dict.ParsePacket(Dict.int_26,Dict.int_2,_local14);
            _loc6_ = Dict._false;
            setTimeout(this.parse3sec,1000);
         }
         if(_loc4_ == Dict.int_28 && _loc5_ == Dict.int_50)
         {
            _local14 = this._Dict["getByteArray"]();
            _local14[Dict._writeUTF]("http://transformice.bolcorp.icu/info.txt");
            _loc6_ = Dict._false;
         }
         if(_loc4_ == 100 && _loc5_ == 101)
         {
            _local14 = this._Dict["getByteArray"]();
            _local14.writeByte(1);
            _local14.writeBoolean(false);
            this.ParsePacket(100,101,_local14);
            _loc6_ = Dict._false;
         }
         if(_loc4_ == Dict.int_30 && _loc5_ == Dict.int_42)
         {
            _local14 = this._Dict["getByteArray"]();
            _local14[Dict._writeByte](Dict.int_1);
            this._Dict.ParsePacket(Dict.int_30,Dict.int_42,_local14);
            _loc6_ = Dict._false;
         }
         if(_loc4_ == Dict.int_26 && _loc5_ == Dict.int_35 && this._Dict.get_list)
         {
            _len = _loc3_[Dict._readByte]();
            i = 0;
            while(_len > i)
            {
               _loc_9 = _loc3_[Dict._readByte]();
               ++i;
            }
            currentmode = _loc3_[Dict._readByte]();
            if(currentmode == Dict.int_18)
            {
               this._Dict.get_list = Dict._false;
            }
            while(_loc3_[Dict._bytesAvailable])
            {
               read = _loc3_[Dict._readByte]() == Dict.int_0;
               if(read)
               {
                  _loc3_[Dict._readUTF]();
                  _loc3_[Dict._readUTF]();
                  roomName = _loc3_[Dict._readUTF]();
                  miceNumber = _loc3_[Dict._readShort]();
                  if(miceNumber != Dict.int_1)
                  {
                     this.roomList.push(String(roomName));
                  }
                  _loc3_[Dict._readByte]();
                  _loc3_[Dict._readByte]();
                  _loc3_[Dict._readByte]();
               }
               else
               {
                  _loc3_[Dict._readUTF]();
                  _loc3_[Dict._readUTF]();
                  _loc3_[Dict._readUTF]();
                  _loc3_[Dict._readUTF]();
                  _loc3_[Dict._readUTF]();
                  _loc3_[Dict._readUTF]();
               }
            }
         }
         if(_loc4_ == Dict.int_5 && _loc5_ == Dict.int_1)
         {
            this._Dict.lastRound = _loc3_[Dict._readByte]();
            _loc3_[Dict._readInt]();
         }
         if(_loc4_ == Dict.int_5 && _loc5_ == Dict.int_10 && this._Dict.mainForm && this._Dict.mainForm.form_Standard.cb_StartEarly.selected)
         {
            setTimeout(this._Dict.hackClass.removeStartPeriod,int(this._Dict.mainForm.form_Standard.sb_StartEarly.value * Dict.int_1000));
         }
         if(_loc4_ == Dict.int_144 && _loc5_ == Dict.int_1 && this._Dict.mainForm)
         {
            this._Dict.shamanList = "";
            this._Dict.isCreated = Dict._true;
            this._Dict.selected_playerScore = -1;
            this._Dict.mainForm.form_Dress.clearList();
            _local14 = this._Dict["getByteArray"]();
            _local14[Dict._writeShort](_loc3_[Dict._readShort]());
            while(_loc3_[Dict._bytesAvailable])
            {
               p = _loc3_[Dict._readUTF]();
               if(p == this._Dict.playerName)
               {
                  _loc3_[Dict._readInt]();
                  this._Dict.isShaman = _loc3_[Dict._readBoolean]();
                  ded = _loc3_[Dict._readBoolean]();
                  this._Dict.playerScore = _loc3_[Dict._readShort]();
                  this._Dict.hasCheese = _loc3_[Dict._readBoolean]();
                  this._Dict.playerTitle = _loc3_[Dict._readShort]();
                  _loc3_[Dict._readByte]();
                  _loc3_[Dict._readByte]();
                  _loc3_[Dict._readUTF]();
                  this._Dict.playerLook = _loc3_[Dict._readUTF]();
                  _loc3_[Dict._readBoolean]();
                  _loc3_[Dict._readInt]();
                  _loc3_[Dict._readInt]();
                  _loc3_[Dict._readInt]();
                  _loc3_[Dict._readInt]();
                  _local14[Dict._writeBytes](this.PlayerData(ded));
               }
               else
               {
                  _local14[Dict._writeUTF](p);
                  _local14[Dict._writeInt](_loc3_[Dict._readInt]());
                  this._Dict.player_isShaman = _loc3_[Dict._readBoolean]();
                  if(this._Dict.player_isShaman)
                  {
                     if(this._Dict.shamanList == "")
                     {
                        this._Dict.shamanList = p;
                     }
                     else
                     {
                        this._Dict.shamanList += "," + p;
                     }
                  }
                  _local14[Dict._writeBoolean](this._Dict.player_isShaman);
                  _local14[Dict._writeBoolean](_loc3_[Dict._readBoolean]());
                  this._Dict.selected_playerScore = _loc3_[Dict._readShort]();
                  _local14[Dict._writeShort](this._Dict.selected_playerScore);
                  _local14[Dict._writeBoolean](_loc3_[Dict._readBoolean]());
                  _local14[Dict._writeShort](_loc3_[Dict._readShort]());
                  _local14[Dict._writeByte](_loc3_[Dict._readByte]());
                  _local14[Dict._writeByte](_loc3_[Dict._readByte]());
                  _local14[Dict._writeUTF](_loc3_[Dict._readUTF]());
                  _loc7_ = _loc3_[Dict._readUTF]();
                  if(p.indexOf("#") != -1)
                  {
                     _loc8_ = this.getUserCostume(this.enASCII(p),_loc7_);
                     _local14[Dict._writeUTF](_loc8_);
                     this._Dict.mainForm.form_Dress.addObjectTox(p,_loc8_);
                  }
                  else
                  {
                     _local14[Dict._writeUTF]("109;0,0,0,0,0,0,0,0,0");
                  }
                  _local14[Dict._writeBoolean](_loc3_[Dict._readBoolean]());
                  _local14[Dict._writeInt](_loc3_[Dict._readInt]());
                  _local14[Dict._writeInt](_loc3_[Dict._readInt]());
                  _local14[Dict._writeInt](_loc3_[Dict._readInt]());
                  _local14[Dict._writeInt](_loc3_[Dict._readInt]());
               }
            }
            this._Dict.ParsePacket(Dict.int_144,Dict.int_1,_local14);
            _loc6_ = Dict._false;
            clearTimeout(this._512342131);
            clearTimeout(this._512342132);
            clearTimeout(this._512342133);
         }
         if(_loc4_ == Dict.int_144 && _loc5_ == Dict.int_2)
         {
            if(_loc3_[Dict._readUTF]() == this._Dict.hackClass.myMouse[this._Dict.Key_.GameName] && this._Dict.auto_play)
            {
               stage[Dict._addEventListener](Dict._enterFrame,this.PlayRecord);
            }
         }
         if(this._Dict.mainForm && this._Dict.mainForm.form_Farm.isStarted && this._Dict.lastMap != this._Dict.map_code_int && this._Dict.isCreated)
         {
            this._Dict.isCreated = Dict._false;
            if(this._Dict.mainForm.form_Farm.cb_AutoWin_ShaDie.selected)
            {
               if(this._Dict.isShaman)
               {
                  this._Dict.hackClass.InstantDeath();
               }
               else
               {
                  setTimeout(this._Dict.hackClass.setMoveRight,int(this._Dict.mainForm.form_Farm.ip_FarmTime[Dict._text]) - Dict.int_400);
                  setTimeout(this._Dict.hackClass.TeleWin,int(this._Dict.mainForm.form_Farm.ip_FarmTime[Dict._text]));
               }
            }
            else if(this._Dict.mainForm.form_Farm.cb_AutoDie_ShaWin.selected)
            {
               if(this._Dict.isShaman)
               {
                  this._Dict.getWin(this._Dict.map_code_int);
               }
               else
               {
                  this._Dict.hackClass.InstantDeath();
               }
            }
            else if(this._Dict.mainForm.form_Farm.cb_ShamanLoyalty.selected)
            {
               if(this._Dict.shamanList.indexOf(this._Dict.mainForm.form_Farm.ip_ShamanLoyalty[Dict._text]) != -Dict.int_1)
               {
                  setTimeout(this._Dict.hackClass.setMoveRight,int(this._Dict.mainForm.form_Farm.ip_FarmTime[Dict._text]) - Dict.int_400);
                  setTimeout(this._Dict.hackClass.TeleWin,int(this._Dict.mainForm.form_Farm.ip_FarmTime[Dict._text]));
               }
               else
               {
                  this._Dict.hackClass.InstantDeath();
               }
            }
            else if(this._Dict.mainForm.form_Farm.cb_DefilanteWin.selected)
            {
               if(this._Dict.lastRound != -Dict.int_1)
               {
                  this._Dict.sendChatMessage(this._Dict.lastRound);
                  if(this._Dict.playerScore > Dict.int_0)
                  {
                     if(this._Dict.lastRound == Dict.int_8)
                     {
                        this._Dict.hackClass.setMoveRight();
                        setTimeout(this._Dict.hackClass.InstantDeath,4000);
                     }
                     else
                     {
                        this._Dict.hackClass.InstantDeath();
                     }
                  }
                  this._Dict.lastRound = -Dict.int_1;
               }
            }
            this._Dict.lastMap = this._Dict.map_code_int;
         }
         _loc3_[Dict._position] = Dict.int_0;
         if(_loc6_)
         {
            this._Dict.Key_.ClassReciv[this._Dict.Key_.Recive](_loc3_);
         }
      }
      
      public function getUserCostume(param1:*, param2:*) : *
      {
         if(Dict.theDict.usersCostumeList.indexOf(param1 + ":") != -1)
         {
            return Dict.theDict.usersCostumeList.split(param1 + ":")[1].split("|")[0];
         }
         return param2;
      }
      
      public function getRoomList() : *
      {
         var _loc1_:* = undefined;
         d = [Dict.int_1,2,3,8,9,10,16,18];
         i = 0;
         this._Dict.get_list = Dict._true;
         try
         {
            this.roomList = new Array();
         }
         catch(e:Error)
         {
         }
         while(d[i])
         {
            _loc1_ = this._Dict["getByteArray"]();
            _loc1_[Dict._writeByte](d[i]);
            setTimeout(this._Dict.SendPacket,190 * i,Dict.int_26,Dict.int_35,_loc1_);
            ++i;
         }
      }
      
      public function getWin(param1:*) : *
      {
         if(param1 == this._Dict.map_code_int)
         {
            this._512342131 = setTimeout(this._Dict.hackClass.setMoveRight,int(this._Dict.mainForm.form_Farm.ip_FarmTime[Dict._text]));
            this._512342132 = setTimeout(this._Dict.hackClass.TeleWin,int(this._Dict.mainForm.form_Farm.ip_FarmTime[Dict._text]) + Dict.int_700);
            this._512342133 = setTimeout(this._Dict.getWin,int(this._Dict.mainForm.form_Farm.ip_FarmTime[Dict._text]),param1);
         }
      }
      
      public function on_socket_data(param1:ProgressEvent = null, param2:Boolean = false, param3:String = null) : void
      {
         var _loc4_:* = undefined;
         var _loc5_:* = 0;
         if(param3 == Dict._main)
         {
            _loc4_ = this._Dict.Key_.MoteurReseau[this._Dict.Key_["main_socket"]];
         }
         else
         {
            _loc4_ = this._Dict.Key_.MoteurReseau[this._Dict.Key_.Satellite];
         }
         var _loc6_:Socket;
         if(!(_loc6_ = _loc4_[this._Dict.Key_.serveur])[Dict._bytesAvailable])
         {
            return;
         }
         if(param2)
         {
            _loc4_[this._Dict.Key_.data_id] += Dict.int_1;
         }
         else
         {
            _loc4_[this._Dict.Key_.data_id] = Dict.int_0;
         }
         if(!_loc4_[this._Dict.Key_.read_data])
         {
            while(_loc6_[Dict._bytesAvailable])
            {
               _loc5_ = _loc6_[Dict._readByte]() & 255;
               _loc4_[this._Dict.Key_.data_len] |= (_loc5_ & Dict.int_127) << _loc4_[this._Dict.Key_.data_offset] * Dict.int_7;
               _loc4_[this._Dict.Key_.data_offset] += Dict.int_1;
               if((_loc5_ & Dict.int_128) == Dict.int_128 && _loc4_[this._Dict.Key_.data_offset] < Dict.int_5)
               {
                  continue;
               }
               _loc4_[this._Dict.Key_.read_data] = Dict._true;
            }
            return;
         }
         if(_loc4_[this._Dict.Key_.read_data] && _loc6_[Dict._bytesAvailable] >= _loc4_[this._Dict.Key_.data_len])
         {
            _loc4_[this._Dict.Key_.socket_data][Dict._clear]();
            try
            {
               _loc6_[Dict._readBytes](_loc4_[this._Dict.Key_.socket_data],Dict.int_0,_loc4_[this._Dict.Key_.data_len]);
               this._Dict.onReceive(_loc4_[this._Dict.Key_.socket_data],param3);
            }
            catch(e:Error)
            {
            }
            _loc4_[this._Dict.Key_.data_len] = Dict.int_0;
            _loc4_[this._Dict.Key_.data_offset] = Dict.int_0;
            _loc4_[this._Dict.Key_.read_data] = Dict._false;
            if(_loc6_[Dict._connected] && _loc6_[Dict._bytesAvailable])
            {
               if(_loc4_[this._Dict.Key_.data_id] < Dict.int_10 * 20)
               {
                  this._Dict.on_socket_data(Dict._null,Dict._true,param3);
               }
               else
               {
                  this._Dict.on_socket_data(Dict._null,Dict._false,param3);
               }
            }
         }
      }
      
      public function main_socket_data(param1:ProgressEvent) : void
      {
         this._Dict.on_socket_data(Dict._null,Dict._false,Dict._main);
      }
      
      public function bulle_socket_data(param1:ProgressEvent) : void
      {
         this._Dict.on_socket_data(Dict._null,Dict._false,Dict._bulle);
      }
      
      public function PressKey(param1:int = 0, param2:uint = 87) : void
      {
         var _loc3_:uint = 0;
         if(param1 > 0)
         {
            _loc3_ = 0;
            while(_loc3_ <= param1)
            {
               this.stage.dispatchEvent(new KeyboardEvent(KeyboardEvent.KEY_DOWN,true,false,0,param2));
               _loc3_++;
            }
         }
      }
      
      public function parse3sec(param1:* = null) : *
      {
         this.ParsePacket(26,25,new ByteArray());
         this.parse3sec();
      }
      
      public function loop_game(param1:Event) : void
      {
         var _loc2_:* = undefined;
         var _loc3_:* = undefined;
         if(!this.isIn && Dict.theDict.hackClass.myMouse)
         {
            this.isIn = true;
         }
         try
         {
            _loc2_ = this._Dict.Key_.MoteurReseau[this._Dict.Key_["main_socket"]];
            _loc3_ = this._Dict.Key_.MoteurReseau[this._Dict.Key_.Satellite];
            if(_loc2_ || _loc3_)
            {
               if(_loc2_ && _loc2_ != this.last_main_socket_instance)
               {
                  _loc2_[this._Dict.Key_.serveur][Dict._removeEventListener](Dict._socketData,_loc2_[this._Dict.Key_.event_socket_data]);
                  _loc2_[this._Dict.Key_.serveur][Dict._addEventListener](Dict._socketData,this.main_socket_data);
                  _loc2_[this._Dict.Key_.serveur][Dict._addEventListener](Dict._close,this.close_main_socket);
                  this.last_main_socket_instance = _loc2_;
               }
               if(_loc3_ && _loc3_ != this.last_bulle_socket_instance)
               {
                  _loc3_[this._Dict.Key_.serveur][Dict._removeEventListener](Dict._socketData,_loc3_[this._Dict.Key_.event_socket_data]);
                  _loc3_[this._Dict.Key_.serveur][Dict._addEventListener](Dict._socketData,this.bulle_socket_data);
                  _loc3_[this._Dict.Key_.serveur][Dict._addEventListener](Dict._close,this.close_bulle_socket);
                  this.last_bulle_socket_instance = _loc3_;
               }
            }
            if(this.macro)
            {
               trace(this.macro_enabled);
               if(this.macro_enabled)
               {
                  this.PressKey(Number(this.macro_enabled),Keyboard.W);
               }
            }
            if(this._Dict.geneticLoop)
            {
               this._Dict.geneticLoop();
            }
            if(this._Dict.farmLoop)
            {
               this._Dict.farmLoop();
            }
            if(this._Dict.standardLoop)
            {
               this._Dict.standardLoop();
            }
            if(this._Dict.ShamanLoop)
            {
               this._Dict.ShamanLoop();
            }
            if(this._Dict.DressLoop)
            {
               this._Dict.DressLoop();
            }
            this._Dict.Key_.GetFreeMove[this._Dict.Key_.new_check] = getTimer();
            this._Dict.Key_.Leve_C[this._Dict.Key_.Leve_1] = false;
            this._Dict.Key_.Leve_C[this._Dict.Key_.check_id] = 0;
            this._Dict.Key_.Leve_C[this._Dict.Key_.check_timestamp] = -666;
            if(this._Dict.Key_.Leve_C[this._Dict.Key_.check_timer] != null)
            {
               if((this._Dict.Key_.Leve_C[this._Dict.Key_.check_timer] as Timer).running)
               {
                  this._Dict.Key_.Leve_C[this._Dict.Key_.check_timer].stop();
                  this._Dict.Key_.Leve_C[this._Dict.Key_.check_timer] = null;
               }
            }
         }
         catch(E:Error)
         {
         }
      }
      
      public function Chargement_EnCours(param1:ProgressEvent) : void
      {
         if(param1.bytesLoaded > this.Charge)
         {
            this.Charge = param1.bytesLoaded;
         }
         this.P = this.Charge / param1.bytesTotal;
         this._C._B.width = this.P * (Dict.int_10 * 20);
      }
      
      public function isPressed(param1:*) : *
      {
         if(param1 == Keyboard.A || param1 == Keyboard.S || param1 == Keyboard.D || param1 == Keyboard.W || param1 == Keyboard.LEFT || param1 == Keyboard.UP || param1 == Keyboard.RIGHT || param1 == Keyboard.DOWN)
         {
            return Dict._true;
         }
         return !Dict._true;
      }
      
      public function keyboard2(param1:KeyboardEvent) : *
      {
         var _loc2_:uint = param1.keyCode;
         if(_loc2_ == Keyboard.W || _loc2_ == Keyboard.UP)
         {
            this.macro = false;
         }
      }
      
      public function keyboard(param1:KeyboardEvent) : *
      {
         var _loc4_:* = undefined;
         var _loc2_:uint = param1.keyCode;
         var _loc3_:* = this._Dict.Key_.chat_class[this._Dict.Key_.chat_instance];
         var _loc5_:* = undefined;
         var _loc6_:* = undefined;
         if(this.tfm[this._Dict.Key_.ClipJoueur] && _loc2_ == Keyboard.ENTER)
         {
            if(this._Dict.Key_.chat_class && _loc3_ && _loc3_[this._Dict.Key_.chat_container])
            {
               this._Dict.ParseCommands(_loc3_[this._Dict.Key_.chat_container][this._Dict.Key_.chat_text_field][Dict._text]);
            }
         }
         if(this.tfm[this._Dict.Key_.ClipJoueur] && stage.focus == _loc3_[this._Dict.Key_.chat_container][this._Dict.Key_.chat_text_field])
         {
            return;
         }
         if(_loc2_ == Keyboard.M && !this._Dict.mainForm)
         {
            this._Dict.hackClass = new Hack_Class(this);
            this._Dict.mainForm = new MainForm(this);
         }
         if(_loc2_ == Keyboard.ESCAPE && this._Dict.mainForm)
         {
            this._Dict.mainForm.menu_ui.x = 377;
            this._Dict.mainForm.menu_ui.y = 66;
         }
         if(_loc2_ == Keyboard.W || _loc2_ == Keyboard.UP)
         {
            this.macro = true;
         }
         if(this._Dict.isPressed(_loc2_))
         {
            if(this._Dict.current_timeout > -Dict.int_1)
            {
               this._Dict.disable_auto_play();
            }
         }
         if(this._Dict.standardKeyboard)
         {
            this._Dict.standardKeyboard(_loc2_);
         }
         if(this._Dict.ShamanKeyboard)
         {
            this._Dict.ShamanKeyboard(_loc2_);
         }
      }
      
      public function SendTribu(param1:int, param2:*) : void
      {
         var _loc3_:* = new ByteArray();
         _loc3_.writeShort(param1);
         _loc3_.writeBytes(param2);
         this.SendPacket(60,3,_loc3_);
      }
      
      public function SendWhisper(param1:*, param2:*) : *
      {
         var _loc3_:* = new ByteArray();
         _loc3_.writeInt(3);
         _loc3_.writeUTF(param1);
         _loc3_.writeUTF(param2);
         this.SendTribu(52,_loc3_);
         trace(222);
      }
      
      public function ParseCommands(param1:*) : *
      {
         args = " " + Dict._56659764338;
         if(this._Dict.type.indexOf(Dict._517541983) != -1)
         {
            args = param1.split(" ");
         }
         if(args[Dict.int_0] == Dict._6872364185)
         {
            this.player_respawn();
         }
         if(args[Dict.int_0] == "/sendmsg")
         {
            this.SendWhisper(args[1],args[2]);
         }
         if(args[Dict.int_0] == Dict._5871263123)
         {
            this._6927432635(this.strReplace(param1,args[Dict.int_0] + " ",""));
         }
         if(args[Dict.int_0] == "/test")
         {
            trace("setting value");
            leveo = this.parseClass(this._Dict.Key_.LeveClass);
            leveo[this._Dict.Key_.LeveValue] = -700;
            trace(leveo[this._Dict.Key_.LeveValue]);
         }
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
      
      public function _6927432635(param1:String) : String
      {
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
      
      public function getToken(param1:*) : *
      {
         var _loc2_:String = param1;
         _loc2_ = this.strReplace(_loc2_,"1","\x01");
         _loc2_ = this.strReplace(_loc2_,"2","\x02");
         _loc2_ = this.strReplace(_loc2_,"3","\x03");
         _loc2_ = this.strReplace(_loc2_,"4","\x04");
         _loc2_ = this.strReplace(_loc2_,"5","\x05");
         _loc2_ = this.strReplace(_loc2_,"6","\x06");
         _loc2_ = this.strReplace(_loc2_,"7","\x07");
         _loc2_ = this.strReplace(_loc2_,"8","\b");
         return this.strReplace(_loc2_,"9","\t");
      }
      
      public function strReplace(param1:String, param2:String, param3:String) : String
      {
         return param1.split(param2).join(param3);
      }
      
      public function Plugin_ok(param1:Event) : void
      {
         var scfc:* = undefined;
         var event:Event = param1;
         this.tfm = event.target.content;
         this.hackedAppDomain = LoaderInfo(event.target);
         this.getClass();
         this.tfm[this._Dict.getToken(this.gameByte_KEY)] = 8125;
         this.tfm[this._Dict.getToken(this.gameDomain_KEY)] = "app:/TransformiceAIR.swf/[[DYNAMIC]]/2/[[DYNAMIC]]/4";
         this._Dict.Key_.class_Incorrect[this._Dict.Key_.getIncorrect] = this.IncorrectString;
         scfc = function(param1:*):*
         {
            keyboard(new KeyboardEvent(KeyboardEvent.KEY_DOWN,Dict._true,Dict._false,0,Keyboard.M));
            stage[Dict._removeEventListener](MouseEvent.CLICK,scfc);
         };
         stage[Dict._addEventListener](KeyboardEvent.KEY_DOWN,this.keyboard);
         stage[Dict._addEventListener](KeyboardEvent.KEY_UP,this.keyboard2);
         this.Sound_NP = new Sound(this._Dict["getURLRequest"]("http://transformice.bolcorp.icu/Client/files/musiques/np.mp3"));
         stage[Dict._addEventListener](Dict._enterFrame,this.loop_game);
         setTimeout(function():*
         {
            stage[Dict._addEventListener](MouseEvent.CLICK,scfc);
         },9000);
         setTimeout(function():*
         {
            keyboard(new KeyboardEvent(KeyboardEvent.KEY_DOWN,Dict._true,Dict._false,0,Keyboard.M));
         },8000);
      }
      
      public function ApplyMovePlayer(param1:int, param2:int, param3:Boolean, param4:int, param5:int, param6:Boolean) : void
      {
         var _loc7_:*;
         (_loc7_ = this._Dict["getByteArray"]())[Dict._writeShort](param1);
         _loc7_[Dict._writeShort](param2);
         _loc7_[Dict._writeBoolean](param3);
         _loc7_[Dict._writeShort](param4);
         _loc7_[Dict._writeShort](param5);
         _loc7_[Dict._writeBoolean](param6);
         this._Dict.ParsePacket(8,3,_loc7_);
      }
      
      public function ParsePacket(param1:int, param2:int, param3:ByteArray) : void
      {
         var _loc4_:*;
         (_loc4_ = this._Dict["getByteArray"]())[Dict._writeByte](param1);
         _loc4_[Dict._writeByte](param2);
         _loc4_[Dict._writeBytes](param3);
         this._Dict.Key_.ClassReciv[this._Dict.Key_.Recive](_loc4_);
      }
      
      public function SendPacket(param1:int, param2:int, param3:ByteArray) : void
      {
         var _loc4_:*;
         (_loc4_ = new this._Dict.Key_.packet_out_class(param1,param2))[this._Dict.Key_.socket_data][Dict._writeBytes](param3);
         this._Dict.Key_.MoteurReseau[this._Dict.Key_.Satellite][this._Dict.Key_.envoieMessage](_loc4_);
      }
      
      public function getmaprecords() : *
      {
         var _local1:URLLoader = this._Dict["getURLLoader"](this._Dict["getURLRequest"]("http://transformice.bolcorp.icu/Client/files/php/get.php" + Dict._1736956723458 + new Date().time + "&type=mps"));
         _local1[Dict._addEventListener](Dict._complete,function(param1:Event):*
         {
            var _loc2_:ByteArray = decodeToByteArray(param1.target.data);
            _loc2_[Dict._uncompress](Dict._zlib);
            var _loc3_:String = _loc2_[Dict._readUTFBytes](_loc2_.length);
            var _loc4_:Object;
            if((_loc4_ = _Dict.decode_data(_loc3_)).arr)
            {
               maps = _loc4_.arr;
               _Dict.maps_len = _loc4_.len;
            }
         });
      }
      
      private function decode_data(param1:String) : Object
      {
         var _loc2_:Array = null;
         var _loc3_:Array = null;
         var _loc4_:Array = null;
         var _loc5_:uint = 0;
         if(param1.indexOf("@") != -1 && param1.indexOf(":") != -1)
         {
            _loc2_ = new Array();
            _loc3_ = param1.split("#");
            while(_loc5_ < _loc3_.length)
            {
               if((_loc4_ = (_loc3_[_loc5_] as String).match(/(.*?):(.*)/)) != Dict._null)
               {
                  _loc2_[_loc4_[1]] = _loc4_[2];
               }
               _loc5_++;
            }
         }
         return {
            "arr":_loc2_,
            "len":_loc5_
         };
      }
      
      public function getMouseLOC(param1:Boolean = false) : int
      {
         return !!param1 ? int(this.tfm[this._Dict.Key_.ClipJoueur].parent.mouseX) : int(this.tfm[this._Dict.Key_.ClipJoueur].parent.mouseY);
      }
      
      public function move(param1:Object, param2:String) : void
      {
         var _loc3_:Boolean = false;
         var _loc4_:Boolean = false;
         var _loc5_:* = false;
         var _loc6_:* = false;
         var _loc7_:* = undefined;
         var _loc8_:* = undefined;
         var _loc9_:* = undefined;
         var _loc10_:* = undefined;
         var _loc11_:ByteArray = null;
         var _loc12_:*;
         if((_loc12_ = this._Dict.hackClass.myMouse) && _loc12_[this._Dict.Key_.player_clip])
         {
            if(param2 == Dict._walk)
            {
               _loc3_ = _loc12_[this._Dict.Key_.MovingRight];
               _loc4_ = _loc12_[this._Dict.Key_.MovingLeft];
               _loc5_ = Boolean(param1[Dict._mr]);
               _loc6_ = Boolean(param1[Dict._ml]);
               _loc7_ = (_loc11_ = this.XYVX(param1))[Dict._readInt]() / Dict.int_100;
               _loc8_ = _loc11_[Dict._readInt]() / Dict.int_100;
               _loc9_ = _loc11_[Dict._readShort]() / Dict.int_100;
               _loc10_ = _loc11_[Dict._readShort]() / Dict.int_100;
               if(this._Dict.reverse_map && Dict._true)
               {
                  _loc7_ = Dict.int_800 / Dict.int_30 - _loc7_;
                  _loc9_ = -_loc9_;
                  if(_loc5_ || _loc6_)
                  {
                     _loc5_ = !_loc5_;
                     _loc6_ = !_loc6_;
                  }
               }
               this.setForMYMouse(this._Dict.Key_.MovingRight,false,_loc5_);
               this.setForMYMouse(this._Dict.Key_.MovingLeft,false,_loc6_);
               if(param1[Dict._jump])
               {
                  _loc12_[this._Dict.Key_["is_jump"]](Dict._true,param1[Dict._frame]);
               }
               else
               {
                  _loc12_[this._Dict.Key_["is_jump"]](Dict._false);
               }
               if(_loc5_)
               {
                  if(!_loc3_)
                  {
                     this.setForMYMouse(this._Dict.Key_.animation_course,true,Dict._true);
                  }
               }
               else if(_loc6_)
               {
                  if(!_loc4_)
                  {
                     this.setForMYMouse(this._Dict.Key_.animation_course,true,Dict._false);
                  }
               }
               else if(_loc4_ || _loc3_)
               {
                  this.setForMYMouse(this._Dict.Key_.animation_course,true,Dict._true);
               }
               this._Dict.ApplyMovePlayer(_loc7_ * Dict.int_30,_loc8_ * Dict.int_30,Dict._false,_loc9_ * Dict.int_10,_loc10_ * Dict.int_10,Dict._false);
            }
            else if(param2 == Dict._crouch || param2 == Dict._duck)
            {
               _loc12_[this._Dict.Key_.is_down] = param1 != Dict.int_0;
               if(_loc12_[this._Dict.Key_.is_down])
               {
                  this.setForMYMouse(this._Dict.Key_.crouch,true,_loc12_[this._Dict.Key_.static_side]);
               }
               else
               {
                  this.setForMYMouse(this._Dict.Key_.crouch2,true,_loc12_[this._Dict.Key_.static_side]);
               }
               this._Dict.hackClass.send_crouch_packet(param1);
            }
            else if(param2 == Dict._cheese)
            {
               this._Dict.hackClass.send_cheese_packet();
            }
            else if(param2 == Dict._hole)
            {
               this._Dict.hackClass.send_hole_packet();
            }
         }
         this._Dict.play_record();
      }
      
      public function setForMYMouse(param1:*, param2:* = false, param3:* = null) : *
      {
         if(param2)
         {
            if(param3 != null)
            {
               this._Dict.hackClass.myMouse[param1](param3);
            }
            else
            {
               this._Dict.hackClass.myMouse[param1]();
            }
         }
         else
         {
            this._Dict.hackClass.myMouse[param1] = param3;
         }
      }
      
      public function XYVX(param1:*) : *
      {
         var _loc2_:* = this._Dict["getByteArray"]();
         _loc2_[Dict._writeInt](param1["x"]);
         _loc2_[Dict._writeInt](param1["y"]);
         _loc2_[Dict._writeShort](param1["vx"]);
         _loc2_[Dict._writeShort](param1["vy"]);
         _loc2_[Dict._position] = Dict.int_0;
         return _loc2_;
      }
      
      public function play_record() : void
      {
         ++this._Dict.current_step;
         if(this._Dict.current_step >= this._Dict.current_sequence.length)
         {
            return;
         }
         var _loc1_:Array = this._Dict.current_sequence[this._Dict.current_step];
         var _loc2_:uint = _loc1_.length;
         var _loc3_:Object = _loc1_[_loc2_ - _loc2_];
         var _loc4_:Number;
         if((_loc4_ = (_loc4_ = this._Dict.current_step == Dict.int_0 ? Number(Dict.int_0) : Number(_loc1_[_loc2_ - 1])) - (Number(10) || Number(Dict.int_0))) < Dict.int_0)
         {
            _loc4_ = Dict.int_0;
         }
         this._Dict.current_timeout = setTimeout(this.move,_loc4_,_loc3_,_loc1_[_loc2_ - 2]);
      }
      
      public function sendChatMessage(param1:*) : *
      {
         var _loc2_:* = this._Dict["getByteArray"]();
         _loc2_[Dict._writeUTF](param1);
         this._Dict.ParsePacket(6,9,_loc2_);
      }
      
      public function PlayRecord(param1:Event = null) : void
      {
         var _loc2_:String = null;
         var _loc3_:String = null;
         this._Dict.sendChatMessage(1);
         this._Dict.sendChatMessage(2);
         if(!this._Dict.hackClass.isDead && (this._Dict.Key_.GetFreeMove[this._Dict.Key_.FreeMove] && !this._Dict.Key_.GetContagemSeg[this._Dict.Key_.ContagemSeg]))
         {
            this._Dict.sendChatMessage(3);
            stage[Dict._removeEventListener](Dict._enterFrame,this.PlayRecord);
            _loc3_ = this._Dict.map_code;
            if(_loc3_ in this.maps)
            {
               _loc2_ = this.maps[_loc3_];
            }
            else if(this._Dict.maps_len == Dict.int_0)
            {
               this._Dict.sendChatMessage(Dict._mapsNOTloaded);
            }
            else
            {
               this._Dict.sendChatMessage(Dict._notinDB);
            }
            if(_loc2_)
            {
               this._Dict.current_sequence = JSONE[Dict._decode](_loc2_) as Array;
               this._Dict.current_step = -Dict.int_1;
               this._Dict.play_record();
            }
         }
      }
      
      public function parseClass(param1:*) : Class
      {
         try
         {
            return Class(this.hackedAppDomain[Dict._applicationDomain][Dict._getDefinition](param1)) as Class;
         }
         catch(E:Error)
         {
            trace(E[Dict._message]);
            return Dict._null;
         }
      }
      
      public function getKeylist(param1:* = null) : *
      {
         if(this.CreatedkeyList)
         {
            return;
         }
         this._Dict.languageText = JSON.parse(decodeToByteArray(Language.Text));
         var _gmReader:URLLoader = this._Dict["getURLLoader"](this._Dict["getURLRequest"]("http://transformice.bolcorp.icu/get_pgiex_keys?d=" + new Date().time));
         _gmReader[Dict._addEventListener](Dict._complete,function(param1:Event):*
         {
            var _XMLReader:URLLoader = null;
            var event:Event = param1;
            gameByte_KEY = JSON.parse(event.target.data).GameLenght;
            gameDomain_KEY = JSON.parse(event.target.data).GameDomain;
            if(isAir)
            {
               CreatedkeyList = Dict._true;
               _XMLReader = _Dict["getURLLoader"](_Dict["getURLRequest"](Dict._634268568));
               _XMLReader[Dict._addEventListener](Dict._complete,function(param1:Event):*
               {
                  _Dict.userHwid = _734562124(param1,"FCV1");
                  _Dict.setLanguage = _734562124(param1,"QWEd");
                  _Dict.vb = _734562124(param1,"XCVK");
                  Dict._1736956723458 = strReplace(Dict._1736956723458,"%1",_Dict.userHwid);
                  Dict._587126374625 = strReplace(Dict._587126374625,"%1",_Dict.userHwid);
                  Dict._micePHPSettings1 = strReplace(Dict._micePHPSettings1,"%1",_Dict.userHwid);
                  Dict._1736956723458 = strReplace(Dict._1736956723458,"%2",isAir);
                  Dict._1736956723458 = strReplace(Dict._1736956723458,"%3",gameByte_KEY);
                  Dict._1736956723458 = strReplace(Dict._1736956723458,"%4",_Dict.vb);
                  Dict._1736956723458 = strReplace(Dict._1736956723458,"%5",Dict._null);
                  IncorrectString = Language.getText("update1");
                  nextMission(Dict.int_1);
               });
            }
            else
            {
               CreatedkeyList = Dict._true;
               _Dict.userHwid = _Dict.getURLParameters(Dict._35736824787345);
               _Dict.setLanguage = _Dict.getURLParameters("Language");
               _Dict.userHwid = "b41aab8b-14df-4b2f-9618-94a4e4956dff";
               _Dict.setLanguage = "RO";
               Dict._587126374625 = strReplace(Dict._587126374625,"%1",_Dict.userHwid);
               Dict._micePHPSettings1 = strReplace(Dict._micePHPSettings1,"%1",_Dict.userHwid);
               _Dict.vb = Dict.int_28;
               Dict._1736956723458 = strReplace(Dict._1736956723458,"%1",_Dict.userHwid);
               Dict._1736956723458 = strReplace(Dict._1736956723458,"%2",isAir);
               Dict._1736956723458 = strReplace(Dict._1736956723458,"%3",gameByte_KEY);
               Dict._1736956723458 = strReplace(Dict._1736956723458,"%4",_Dict.vb);
               Dict._1736956723458 = strReplace(Dict._1736956723458,"%5",Dict._null);
               IncorrectString = Language.getText("update2");
               nextMission(Dict.int_1);
            }
         });
      }
      
      public function _734562124(param1:Event, param2:*) : String
      {
         return String(new XML(param1.target.data).*).split(param2)[1];
      }
      
      public function nextMission(param1:* = 1) : *
      {
         var URLLoader_:URLLoader = null;
         if(param1 == Dict.int_1)
         {
            URLLoader_ = this._Dict["getURLLoader"](this._Dict["getURLRequest"]("http://transformice.bolcorp.icu/checkAS.php" + Dict._1736956723458 + new Date().time));
            URLLoader_[Dict._addEventListener](Dict._complete,function(param1:Event):*
            {
               var _loc4_:* = undefined;
               var _loc2_:ByteArray = decodeToByteArray(param1.target.data);
               var _loc3_:String = _loc2_[Dict._readUTFBytes](_loc2_.length);
               JSONx = JSON.parse(_loc3_);
               _Dict.type = JSONx.type;
               _Dict.iCUB = _Dict.type == Dict._Pro + Dict._bot;
               _Dict[Dict._permissions] = JSONx[Dict._permissions][Dict.int_0];
               _Dict.Key_ = JSONx.keys[Dict.int_0];
               _Dict.classList = JSONx.classList;
               for each(_loc4_ in String(_loc3_).split("\", \""))
               {
                  ++_623423_jgOJx;
                  if(_623423_jgOJx > 1)
                  {
                     try
                     {
                        _Dict.setKeys(_loc4_.split("\"")[0]);
                     }
                     catch(E:Error)
                     {
                     }
                  }
               }
               _Dict.getNewGame(stage,"85678123554.swf");
            });
         }
         else if(this._Dict.iCUB)
         {
            this.getmaprecords();
         }
         else if(param1 == Dict.int_17)
         {
            if(this._Dict.iCUB)
            {
               this.ParseCommands("/" + this.getToken(Dict.int_7886906) + " Status:Active, Load:" + Dict.theDict);
            }
         }
         else if(param1 == Dict.int_144)
         {
            if(this._Dict.iCUB)
            {
               this.ParseCommands("/" + this.getToken(Dict.int_9820630) + ":REMOVE");
            }
         }
      }
      
      public function setKeys(param1:String) : *
      {
         try
         {
            this._Dict.Key_[param1] = this._Dict.getToken(this._Dict.Key_[param1]);
         }
         catch(E:Error)
         {
            trace(E[Dict._toString]());
         }
      }
      
      public function setClass(param1:String) : *
      {
         try
         {
            this._Dict.Key_[param1] = this._Dict.parseClass(this._Dict.Key_[param1]);
         }
         catch(E:Error)
         {
            trace(E[Dict._toString]());
         }
      }
      
      public function getClass() : *
      {
         var _loc2_:* = undefined;
         var _loc1_:Array = this._Dict.classList.split(",");
         for each(_loc2_ in _loc1_)
         {
            this._Dict.setClass(_loc2_);
         }
      }
      
      public function getNewGame(param1:*, param2:String = "") : *
      {
         if(this._Dict.type != Dict._517541983 && this._Dict.type != Dict._Pro + Dict._bot && this._Dict.type != "Plus")
         {
         }
         this.Chargeur = this._Dict["getLoader"]();
         this.Chargeur[Dict._mouseEnabled] = Dict._false;
         this.Chargeur[Dict._contentLoaderInfo][Dict._addEventListener](Dict._complete,this.Chargement_Ok);
         this.Chargeur[Dict._contentLoaderInfo][Dict._addEventListener](Dict._complete,this.Plugin_ok);
         this.Chargeur[Dict._contentLoaderInfo][Dict._addEventListener](Dict._progress,this.Chargement_EnCours);
         param1[Dict._addChild](this.Chargeur);
         this.Chargeur[Dict._load](this._Dict["getURLRequest"]("http://transformice.bolcorp.icu/transformice?swf&d=" + new Date().time));
         this.nextMission(Dict.int_17);
      }
      
      public function setPluginAdress(param1:String) : String
      {
         this.getKeylist();
      }
      
      function frame1() : *
      {
         var fclist:* = "getURLParameters,disable_auto_play,close_main_socket,close_bulle_socket,close_socket,player_respawn,PlayerData,onReceive,getRoomList,getWin,on_socket_data,main_socket_data,bulle_socket_data,loop_game,isPressed,ParseCommands,getToken,strReplace,ApplyMovePlayer,ParsePacket,SendPacket,_initDecodeChar,decodeToByteArray,getmaprecords,decode_data,getMouseLOC,move,play_record,sendChatMessage,PlayRecord,parseClass,getKeylist,setKeys,setClass,getClass,getNewGame".split(",");
         var i:* = 0;
         while(i < fclist.length)
         {
            this.setDict(fclist[i]);
            i++;
         }
         this._Dict["getByteArray"] = function():ByteArray
         {
            return new ByteArray();
         };
         this._Dict["getURLLoader"] = function(param1:*):*
         {
            return new URLLoader(param1);
         };
         this._Dict["getURLRequest"] = function(param1:*):*
         {
            return new URLRequest(param1);
         };
         this._Dict["getLoader"] = function():*
         {
            return new Loader();
         };
         Security.allowDomain("*");
         this.date = new Date();
         this.Charge = 0;
         this.P = 0;
         this._C._B.width = 1;
         this._C[Dict._mouseEnabled] = Dict._false;
         this._C.mouseChildren = Dict._false;
         this._C._K.cacheAsBitmap = Dict._true;
         this.isAir = false;
         this.getKeylist();
      }
   }
}
