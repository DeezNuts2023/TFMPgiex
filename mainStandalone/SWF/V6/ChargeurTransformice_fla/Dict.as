package ChargeurTransformice_fla
{
   import flash.display.*;
   import flash.events.*;
   import flash.net.*;
   import flash.system.*;
   import flash.text.*;
   import flash.ui.*;
   import flash.utils.*;
   
   public dynamic class Dict extends MovieClip
   {
      
      public static var theDict:Dictionary = new Dictionary();
      
      public static var currentEvent:String = "null";
      
      public static var _Christmas:String = "Christmas";
      
      public static var _readInt:String = "readInt";
      
      public static var _readShort:String = "readShort";
      
      public static var _readByte:String = "readByte";
      
      public static var _readBytes:String = "readBytes";
      
      public static var _uncompress:String = "uncompress";
      
      public static var _position:String = "position";
      
      public static var _readUTFBytes:String = "readUTFBytes";
      
      public static var _readUTF:String = "readUTF";
      
      public static var _readBoolean:String = "readBoolean";
      
      public static var _writeInt:String = "writeInt";
      
      public static var _writeShort:String = "writeShort";
      
      public static var _writeByte:String = "writeByte";
      
      public static var _writeBytes:String = "writeBytes";
      
      public static var _writeUTFBytes:String = "writeUTFBytes";
      
      public static var _writeUTF:String = "writeUTF";
      
      public static var _writeBoolean:String = "writeBoolean";
      
      public static var _readUnsignedByte:String = "readUnsignedByte";
      
      public static var _writeObject:String = "writeObject";
      
      public static var _readObject:String = "readObject";
      
      public static var _zlib:String = "zlib";
      
      public static var _addEventListener:String = "addEventListener";
      
      public static var _enterFrame:String = "enterFrame";
      
      public static var _parameters:String = "parameters";
      
      public static var _loaderInfo:String = "loaderInfo";
      
      public static var _url:String = "url";
      
      public static var _removeEventListener:String = "removeEventListener";
      
      public static var _currentTarget:String = "currentTarget";
      
      public static var _bytesAvailable:String = "bytesAvailable";
      
      public static var _clear:String = "clear";
      
      public static var _connected:String = "connected";
      
      public static var _main:String = "main";
      
      public static var _bulle:String = "bulle";
      
      public static var _socketData:String = "socketData";
      
      public static var _close:String = "close";
      
      public static var _progress:String = "progress";
      
      public static var _complete:String = "complete";
      
      public static var _mouseEnabled:String = "mouseEnabled";
      
      public static var _contentLoaderInfo:String = "contentLoaderInfo";
      
      public static var _addChild:String = "addChild";
      
      public static var _load:String = "load";
      
      public static var _toString:String = "toString";
      
      public static var _applicationDomain:String = "applicationDomain";
      
      public static var _getDefinition:String = "getDefinition";
      
      public static var _message:String = "message";
      
      public static var _decode:String = "decode";
      
      public static var _cheese:String = "cheese";
      
      public static var _hole:String = "hole";
      
      public static var _crouch:String = "crouch";
      
      public static var _duck:String = "duck";
      
      public static var _jump:String = "jump";
      
      public static var _frame:String = "frame";
      
      public static var _walk:String = "walk";
      
      public static var _mr:String = "mr";
      
      public static var _ml:String = "ml";
      
      public static var _et:String = "@";
      
      public static var _text:String = "text";
      
      public static var _substr:String = "substr";
      
      public static var _selected:String = "selected";
      
      public static var _push:String = "push";
      
      public static var _indexOf:String = "indexOf";
      
      public static var _target:String = "target";
      
      public static var _content:String = "content";
      
      public static var _length:String = "length";
      
      public static var _parent:String = "parent";
      
      public static var _mouseX:String = "mouseX";
      
      public static var _mouseY:String = "mouseY";
      
      public static var _split:String = "split";
      
      public static var _width:String = "width";
      
      public static var _mouseChildren:String = "mouseChildren";
      
      public static var _enabled:String = "enabled";
      
      public static var _available:String = "available";
      
      public static var _addCallback:String = "addCallback";
      
      public static var _call:String = "call";
      
      public static var _alpha:String = "alpha";
      
      public static var _type:String = "type";
      
      public static var _visible:String = "visible";
      
      public static var _play:String = "play";
      
      public static var _maxChars:String = "maxChars";
      
      public static var _value:String = "value";
      
      public static var _keyCode:String = "keyCode";
      
      public static var _removeChild:String = "removeChild";
      
      public static var _stage:String = "stage";
      
      public static var _toUpperCase:String = "toUpperCase";
      
      public static var _replace:String = "replace";
      
      public static var _textField:String = "textField";
      
      public static var _selectable:String = "selectable";
      
      public static var _setSelection:String = "setSelection";
      
      public static var _focus:String = "focus";
      
      public static var _fromCharCode:String = "fromCharCode";
      
      public static var _charCodeAt:String = "charCodeAt";
      
      public static var _charCode:String = "charCode";
      
      public static var _keyDown:String = "keyDown";
      
      public static var _click:String = "click";
      
      public static var _change:String = "change";
      
      public static var _permissions:String = "permissions";
      
      public static var _iCUAP:String = "iCUAP";
      
      public static var _iCUBD:String = "iCUBD";
      
      public static var _bdFunction:String = "bdFunction";
      
      public static var _C:String = "C";
      
      public static var _Pro:String = "Pro";
      
      public static var _bot:String = "bot";
      
      public static var _s8V:String = "s8V";
      
      public static var _PGQA:String = "PGQA";
      
      public static var _roomInformation:String = "<R>Map code: <J>%1</J>, mice: <J>%2";
      
      public static var _mapsNOTloaded:String = "<R>Maps not loaded!";
      
      public static var _notinDB:String = "<R>This map is not in the database!";
      
      public static var _8456784567:String = "app:";
      
      public static var _35736824787345:String = "hwid";
      
      public static var _634268568:String = "META-INF/AIR/application.xml";
      
      public static var _1736956723458:String = "?hbid=%1&pID=%2&pgpre&pgc=%3&vb=%4&sl=%5&d=";
      
      public static var _587126374625:String = ".php?hbid=%1&nickname=%2&outfit=%3&get=all";
      
      public static var _micePHPSettings1:String = ".php?hbid=%1&nickname=%2";
      
      public static var _outfit:String = "&outfit=%3";
      
      public static var _so:String = "&so=";
      
      public static var _micePHPSettings:String = ".php?get=all&d=";
      
      public static var _56659764338:String = "function(){return navigator.appVersion+\'-\'+navigator.appName;}";
      
      public static var _72783451:String = "null";
      
      public static var _4845672345334:String = "Check";
      
      public static var _517541983:String = "Pro";
      
      public static var _6872364185:String = "/respawn";
      
      public static var _5871263123:String = "/croom";
      
      public static var _58713421353:String = "Collect box";
      
      public static var _823417396732:String = "642fff95-0b3d-4b51-89c8-962da4775d3e";
      
      public static var int_0:int = 0;
      
      public static var int_1:int = 1;
      
      public static var int_2:int = 2;
      
      public static var int_3:int = 3;
      
      public static var int_4:int = 4;
      
      public static var int_5:int = 5;
      
      public static var int_6:int = 6;
      
      public static var int_7:int = 7;
      
      public static var int_8:int = 8;
      
      public static var int_9:int = 9;
      
      public static var int_10:int = 10;
      
      public static var int_11:int = 11;
      
      public static var int_12:int = 12;
      
      public static var int_13:int = 13;
      
      public static var int_14:int = 14;
      
      public static var int_15:int = 15;
      
      public static var int_16:int = 16;
      
      public static var int_17:int = 17;
      
      public static var int_18:int = 18;
      
      public static var int_19:int = 19;
      
      public static var int_20:int = 20;
      
      public static var int_26:int = 26;
      
      public static var int_28:int = 28;
      
      public static var int_30:int = 30;
      
      public static var int_35:int = 35;
      
      public static var int_42:int = 42;
      
      public static var int_50:int = 50;
      
      public static var int_100:int = 100;
      
      public static var int_127:int = 127;
      
      public static var int_128:int = 128;
      
      public static var int_144:int = 144;
      
      public static var int_400:int = 400;
      
      public static var int_700:int = 700;
      
      public static var int_800:int = 800;
      
      public static var int_1000:int = 1000;
      
      public static var int_7886906:int = 7886906;
      
      public static var int_9820630:int = 9820630;
      
      public static var _true:Boolean = true;
      
      public static var _false:Boolean = false;
      
      public static var _null = null;
       
      
      public function Dict()
      {
         super();
      }
      
      public static function get DTimer() : int
      {
         return getTimer();
      }
      
      public static function Eksi(param1:int, param2:int) : int
      {
         return param1 - param2;
      }
      
      public static function BEsittir(param1:int, param2:int) : Boolean
      {
         return param1 >= param2;
      }
   }
}
