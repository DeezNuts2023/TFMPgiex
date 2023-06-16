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
   
   public dynamic class Flood extends MovieClip
   {
       
      
      public var Key_:Object;
      
      public var tfm;
      
      public var hackClass;
      
      public var mainForm:MainForm;
      
      public var main_:TransformiceChargeur;
      
      public var page_1:Sprite;
      
      public var page_2:Sprite;
      
      public var _sprite:Sprite;
      
      public var cb_Message1:CheckBox;
      
      public var cb_Message2:CheckBox;
      
      public var cb_Message3:CheckBox;
      
      public var cb_Message4:CheckBox;
      
      public var ip_Message1:InputText;
      
      public var ip_Message2:InputText;
      
      public var ip_Message3:InputText;
      
      public var ip_Message4:InputText;
      
      public var lb_MC1:Label;
      
      public var lb_MC2:Label;
      
      public var lb_MC3:Label;
      
      public var lb_MC4:Label;
      
      public var cb_GlobalRooms:CheckBox;
      
      public var cb_LocalRooms:CheckBox;
      
      public var pb_Start:PushButton;
      
      public var pb_Pause:PushButton;
      
      public var pb_CopyNames:PushButton;
      
      public var pb_GetMiceNamesFromThisRoom:PushButton;
      
      public var pb_GetMiceNamesFromOtherRoom:PushButton;
      
      public var lb_MessageType:Label;
      
      public var lb_MessageQueue:Label;
      
      public var lb_Time:Label;
      
      public var lb_MessageSendingSettings:Label;
      
      public var cb_SendOnly1Message:CheckBox;
      
      public var cb_SendAllActiveMessages:CheckBox;
      
      public var lb_Room:Label;
      
      public var lb_Users:Label;
      
      public var ip_Room:InputText;
      
      public var ip_Users:InputText;
      
      public var cb_Normal:CheckBox;
      
      public var cb_Private:CheckBox;
      
      public var cb_Ordered:CheckBox;
      
      public var cb_Mixed:CheckBox;
      
      public var cb_0_5H:CheckBox;
      
      public var cb_5_20H:CheckBox;
      
      public var cb_20H:CheckBox;
      
      public var pb_ShowPage1:PushButton;
      
      public var pb_ShowPage2:PushButton;
      
      public var roomList:String = "";
      
      public var miceList:String = "";
      
      public var delayRoom:int = 0;
      
      public var indexRoom:int = 0;
      
      public var delayPriv:int = 0;
      
      public var indexPriv:int = 0;
      
      public var isPaused:Boolean = false;
      
      var Msgint:int = 0;
      
      var maxMessage:int = 4;
      
      public function Flood(param1:*)
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
         this.page_1 = new Sprite();
         this.page_2 = new Sprite();
         this._sprite.addChild(this.page_1);
         this._sprite.addChild(this.page_2);
         this.page_2.visible = false;
         this.cb_Message1 = new CheckBox(this.page_1,10,10,"",function():*
         {
            radio = cb_Message1;
            maxMessage = 1;
         });
         this.cb_Message2 = new CheckBox(this.page_1,10,30,"",function():*
         {
            radio = cb_Message2;
            maxMessage = 2;
         });
         this.cb_Message3 = new CheckBox(this.page_1,10,50,"",function():*
         {
            radio = cb_Message3;
            maxMessage = 3;
         });
         this.cb_Message4 = new CheckBox(this.page_1,10,70,"",function():*
         {
            radio = cb_Message4;
            maxMessage = 4;
         });
         this.ip_Message1 = new InputText(this.page_1,30,10,"Message1");
         this.ip_Message1.width = 130;
         this.ip_Message2 = new InputText(this.page_1,30,30,"Message2");
         this.ip_Message2.width = 130;
         this.ip_Message3 = new InputText(this.page_1,30,50,"Message3");
         this.ip_Message3.width = 130;
         this.ip_Message4 = new InputText(this.page_1,30,70,"Message4");
         this.ip_Message4.width = 130;
         this.radio = this.cb_Message4;
         this.lb_MC1 = new Label(this.page_1,170,10,"8/72");
         this.lb_MC2 = new Label(this.page_1,170,30,"8/72");
         this.lb_MC3 = new Label(this.page_1,170,50,"8/72");
         this.lb_MC4 = new Label(this.page_1,170,70,"8/72");
         this.mainForm.set_shape(this.page_1,218,10,false,80);
         this.mainForm.set_shape(this.page_1,10,91,true,362);
         this.lb_Room = new Label(this.page_1,230,10,Language.getText("Room") + ":");
         this.lb_Users = new Label(this.page_1,230,50,Language.getText("Users") + ":");
         this.ip_Room = new InputText(this.page_1,230,30,"1,vanilla1,racing1,bootcamp1,village1",function(param1:*):*
         {
            lb_Room.text = Language.getText("Room") + ":(" + ip_Room.text.split(",").length + ")";
         });
         this.ip_Users = new InputText(this.page_1,230,70,"",function(param1:*):*
         {
            lb_Users.text = Language.getText("Users") + ":(" + ip_Users.text.split(",").length + ")";
            if(ip_Users.text == "")
            {
               lb_Users.text = Language.getText("Users") + ":";
            }
         });
         this.lb_Room.text = Language.getText("Room") + ":(" + this.ip_Room.text.split(",").length + ")";
         this.ip_Room.width = 140;
         this.ip_Users.width = 140;
         this.pb_Pause = new PushButton(this.page_1,10,145,Language.getText("Pause"),function():*
         {
            isPaused = true;
            pb_Pause.visible = false;
            delayRoom = 0;
            delayPriv = 0;
            pb_Start.label = Language.getText("Start");
         });
         this.pb_Start = new PushButton(this._sprite,10,165,Language.getText("Start"),function():*
         {
            delayRoom = 0;
            delayPriv = 0;
            if(pb_Start.label == Language.getText("Start"))
            {
               if(ip_Users.text == "" && cb_Private.selected)
               {
                  TransformiceChargeur.instance.sendChatMessage("<ROSE>You didnt add any name.");
               }
               else if(ip_Room.text == "" && cb_Normal.selected)
               {
                  TransformiceChargeur.instance.sendChatMessage("<ROSE>Add some room.");
               }
               else
               {
                  pb_Start.label = Language.getText("Stop");
                  pb_Pause.visible = true;
                  if(!isPaused)
                  {
                     indexPriv = 0;
                     indexRoom = 0;
                     FloodEnable = true;
                  }
                  isPaused = false;
                  sendMessage();
               }
            }
            else
            {
               pb_Start.label = Language.getText("Start");
               pb_Pause.visible = false;
               isPaused = false;
               FloodEnable = false;
            }
         });
         this.pb_Pause.visible = false;
         this.pb_CopyNames = new PushButton(null,230,55,Language.getText("CopyNames"));
         this.pb_CopyNames.width = 145;
         this.pb_CopyNames.enabled = false;
         this.pb_GetMiceNamesFromThisRoom = new PushButton(this.page_1,10,100,Language.getText("GetMiceNamesFromThisRoom"),function():*
         {
            getMiceNames();
         });
         this.pb_GetMiceNamesFromThisRoom.width = 365;
         this.pb_GetMiceNamesFromOtherRoom = new PushButton(this.page_1,10,120,Language.getText("GetMiceNamesFromOtherRoom"),function():*
         {
            FloodEnable = false;
            getMiceNamesFromRooms(ip_Room.text);
         });
         this.pb_GetMiceNamesFromOtherRoom.width = 365;
         this.pb_ShowPage1 = new PushButton(this._sprite,174,165,Language.getText("Spambot"),function():*
         {
            page_1.visible = true;
            page_2.visible = false;
            pb_ShowPage1.basili2 = true;
            pb_ShowPage2.basili2 = false;
         });
         this.pb_ShowPage1.basili2 = true;
         this.pb_ShowPage2 = new PushButton(this._sprite,275,165,Language.getText("Rules"),function():*
         {
            page_1.visible = false;
            page_2.visible = true;
            pb_ShowPage1.basili2 = false;
            pb_ShowPage2.basili2 = true;
         });
         this.lb_MessageType = new Label(this.page_2,10,10,Language.getText("MessageType") + ":");
         this.lb_MessageQueue = new Label(this.page_2,10,30,Language.getText("MessageQueue") + ":");
         this.lb_Time = new Label(this.page_2,10,50,"/time :");
         this.lb_MessageSendingSettings = new Label(this.page_2,10,70,"[" + Language.getText("MessageSendingSettings") + "]");
         this.cb_Normal = new CheckBox(this.page_2,this.lb_MessageType.width + 20,10,Language.getText("Normal"),function():*
         {
            cb_Normal.selected = true;
            cb_Private.selected = false;
         });
         this.cb_Private = new CheckBox(this.page_2,this.cb_Normal.width + this.cb_Normal.x + 10,10,Language.getText("Private"),function():*
         {
            cb_Private.selected = true;
            cb_Normal.selected = false;
         });
         this.cb_Private.enabled = false;
         this.cb_Ordered = new CheckBox(this.page_2,this.lb_MessageQueue.width + this.lb_MessageQueue.x + 10,30,Language.getText("Ordered"),function():*
         {
            cb_Ordered.selected = true;
            cb_Mixed.selected = false;
         });
         this.cb_Mixed = new CheckBox(this.page_2,this.cb_Ordered.width + this.cb_Ordered.x + 10,30,Language.getText("Mixed"),function():*
         {
            cb_Mixed.selected = true;
            cb_Ordered.selected = false;
         });
         this.cb_0_5H = new CheckBox(this.page_2,this.lb_Time.width + this.lb_Time.x + 10,50,"0-5H",function():*
         {
            cb_0_5H.selected = true;
            cb_5_20H.selected = false;
            cb_20H.selected = false;
            cb_Private.selected = false;
            cb_Private.enabled = false;
            cb_Normal.selected = true;
            setMaxChars();
         });
         this.cb_5_20H = new CheckBox(this.page_2,this.cb_0_5H.width + this.cb_0_5H.x + 10,50,"5-20H",function():*
         {
            cb_5_20H.selected = true;
            cb_0_5H.selected = false;
            cb_20H.selected = false;
            cb_Private.enabled = true;
            setMaxChars();
         });
         this.cb_20H = new CheckBox(this.page_2,this.cb_5_20H.width + this.cb_5_20H.x + 10,50,"20H+",function():*
         {
            cb_20H.selected = true;
            cb_5_20H.selected = false;
            cb_0_5H.selected = false;
            cb_Private.enabled = true;
            setMaxChars();
         });
         this.cb_SendOnly1Message = new CheckBox(this.page_2,10,90,Language.getText("SendOnly1Message"),function():*
         {
            cb_SendOnly1Message.selected = true;
            cb_SendAllActiveMessages.selected = false;
         },false);
         this.cb_SendAllActiveMessages = new CheckBox(this.page_2,10,110,Language.getText("SendAllActiveMessages"),function():*
         {
            cb_SendOnly1Message.selected = false;
            cb_SendAllActiveMessages.selected = true;
         },false);
         this.cb_SendOnly1Message.selected = true;
         this.cb_0_5H.selected = true;
         this.cb_Normal.selected = true;
         this.cb_Ordered.selected = true;
         if(Dict.theDict.type.indexOf("Pro") == -1)
         {
            this.page_1.mouseChildren = false;
            this.page_2.mouseChildren = false;
            this.pb_Start.mouseEnabled = false;
            this.Key_.ui_manager_class[this.Key_.on_mouse_box](this.page_1,"Premium");
            this.Key_.ui_manager_class[this.Key_.on_mouse_box](this.page_2,"Premium");
            this.Key_.ui_manager_class[this.Key_.on_mouse_box](this.pb_Start,"Premium");
         }
      }
      
      public function sendMessage() : *
      {
         this.delayRoom = 0;
         this.delayPriv = 0;
         if(this.pb_Start.label == Language.getText("Start"))
         {
            return;
         }
         if(this.cb_Private.selected)
         {
            if(this.cb_SendAllActiveMessages.selected)
            {
               this.sendAllSelected(this.maxMessage);
            }
            else
            {
               this.sendAllSelected(1);
            }
            ++this.indexPriv;
            if(this.indexPriv == this.ip_Users.text.split(",").length)
            {
               this.indexPriv = 0;
               this.pb_Start.label = Language.getText("Start");
               this.pb_Pause.visible = false;
               this.isPaused = false;
               this.FloodEnable = true;
               return;
            }
            setTimeout(this.sendMessage,this.delayPriv);
         }
         else
         {
            this.hackClass.chatCommand("room " + this.ip_Room.text.split(",")[this.indexRoom]);
            ++this.indexRoom;
            if(this.cb_SendAllActiveMessages.selected)
            {
               this.sendAllSelected(this.maxMessage);
            }
            else
            {
               this.sendAllSelected(1);
            }
            this.delayRoom += 1500;
            if(this.indexRoom == this.ip_Room.text.split(",").length)
            {
               this.indexRoom = 0;
               this.pb_Start.label = Language.getText("Start");
               this.pb_Pause.visible = false;
               this.isPaused = false;
               this.FloodEnable = true;
               return;
            }
            setTimeout(this.sendMessage,this.delayRoom);
         }
      }
      
      public function sendAllSelected(param1:int) : *
      {
         var _loc2_:int = 0;
         while(_loc2_ < param1)
         {
            if(!this.cb_Private.selected)
            {
               this.delayRoom += 1500;
               setTimeout(this.hackClass.sendChatMessage,this.delayRoom,this.nextMessage);
            }
            else
            {
               this.delayPriv += 1500;
               setTimeout(this.hackClass.sendPrivMessage,this.delayPriv,this.ip_Users.text.split(",")[this.indexPriv],this.nextMessage.replace("USERNAME",this.ip_Users.text.split(",")[this.indexPriv]));
            }
            _loc2_++;
         }
      }
      
      public function setMaxChars() : *
      {
         var _loc1_:int = 247;
         if(!this.cb_20H.selected)
         {
            _loc1_ = 72;
         }
         this.ip_Message1.text = this.ip_Message1.text.substr(0,_loc1_);
         this.ip_Message2.text = this.ip_Message2.text.substr(0,_loc1_);
         this.ip_Message3.text = this.ip_Message3.text.substr(0,_loc1_);
         this.ip_Message4.text = this.ip_Message4.text.substr(0,_loc1_);
         this.lb_MC1.text = this.ip_Message1.text.length + "/" + _loc1_;
         this.lb_MC2.text = this.ip_Message2.text.length + "/" + _loc1_;
         this.lb_MC3.text = this.ip_Message3.text.length + "/" + _loc1_;
         this.lb_MC4.text = this.ip_Message4.text.length + "/" + _loc1_;
         this.ip_Message1.maxChars = _loc1_;
         this.ip_Message2.maxChars = _loc1_;
         this.ip_Message3.maxChars = _loc1_;
         this.ip_Message4.maxChars = _loc1_;
      }
      
      private function set FloodEnable(param1:Boolean) : *
      {
         if(Dict.theDict.type != "Pro")
         {
            param1 = false;
         }
         if(!param1)
         {
            this.page_1.alpha = 0.5;
            this.page_2.alpha = 0.5;
         }
         else
         {
            this.page_1.alpha = 1;
            this.page_2.alpha = 1;
         }
         this.pb_Start.enabled = param1;
         this.page_1.mouseEnabled = param1;
         this.page_2.mouseEnabled = param1;
         this.page_1.mouseChildren = param1;
         this.page_2.mouseChildren = param1;
      }
      
      public function startWith(param1:String, param2:String = "*") : Boolean
      {
         if(param1.substr(0,1) == param2)
         {
            return true;
         }
         return false;
      }
      
      public function getMiceNames() : *
      {
         var _loc1_:* = undefined;
         for each(_loc1_ in this.tfm[this.Key_.ListeJoueur])
         {
            if(_loc1_[this.Key_.GameName] != this.tfm[this.Key_.ClipJoueur][this.Key_.GameName] && !this.startWith(_loc1_[this.Key_.GameName]) && _loc1_[this.Key_.GameName].indexOf("#") != -1 && this.ip_Users.text.indexOf(_loc1_[this.Key_.GameName]) == -1)
            {
               if(this.ip_Users.text == "")
               {
                  this.ip_Users.text = _loc1_[this.Key_.GameName];
               }
               else
               {
                  this.ip_Users.text += "," + _loc1_[this.Key_.GameName];
               }
            }
         }
      }
      
      public function get nextMessage() : String
      {
         var _loc1_:* = undefined;
         if(this.ip_Message1.text == "")
         {
            this.ip_Message1.text = "room " + Randomize.GetRandomRoomName();
         }
         if(this.cb_Message4.selected)
         {
            _loc1_ = 4;
            if(this.ip_Message4.text == "")
            {
               this.radio = this.cb_Message3;
            }
         }
         if(this.cb_Message3.selected)
         {
            _loc1_ = 3;
            if(this.ip_Message3.text == "")
            {
               this.radio = this.cb_Message2;
            }
         }
         if(this.cb_Message2.selected)
         {
            _loc1_ = 2;
            if(this.ip_Message2.text == "")
            {
               this.radio = this.cb_Message1;
            }
         }
         if(this.cb_Message1.selected)
         {
            _loc1_ = 1;
         }
         ++this.Msgint;
         if(this.cb_Mixed.selected)
         {
            this.Msgint = Randomize.randomNumberGenerator(1,_loc1_);
         }
         if(this.Msgint < 1 || this.Msgint > _loc1_)
         {
            this.Msgint = 1;
         }
         if(this["ip_Message" + this.Msgint].text == "")
         {
            return this.nextMessage;
         }
         var _loc2_:* = "";
         if(this.Msgint == Randomize.randomNumberGenerator(1,4))
         {
            _loc2_ = Randomize.GetRandomSPCha();
         }
         return _loc2_ + this["ip_Message" + this.Msgint].text + " [" + Randomize.GetRandomCha(Randomize.randomNumberGenerator(2,6)) + "]";
      }
      
      public function getMiceNamesFromRooms(param1:String) : *
      {
         var roomlist:String = param1;
         var changeRoom:* = this.hackClass.chatCommand;
         var roomInt:* = 0;
         i = 0;
         while(i < roomlist.split(",").length)
         {
            setTimeout(changeRoom,roomInt,"room " + roomlist.split(",")[i]);
            setTimeout(this.getMiceNames,roomInt + 1000);
            roomInt += 2000;
            ++i;
         }
         setTimeout(function():*
         {
            FloodEnable = true;
         },roomInt);
      }
      
      public function set radio(param1:CheckBox) : *
      {
         this.cb_Message1.selected = false;
         this.cb_Message2.selected = false;
         this.cb_Message3.selected = false;
         this.cb_Message4.selected = false;
         param1.selected = true;
         if(this.cb_Message4.selected)
         {
            this.ip_Message1.enabled = true;
            this.ip_Message2.enabled = true;
            this.ip_Message3.enabled = true;
            this.ip_Message4.enabled = true;
         }
         if(this.cb_Message3.selected)
         {
            this.ip_Message1.enabled = true;
            this.ip_Message2.enabled = true;
            this.ip_Message3.enabled = true;
            this.ip_Message4.enabled = false;
         }
         if(this.cb_Message2.selected)
         {
            this.ip_Message1.enabled = true;
            this.ip_Message2.enabled = true;
            this.ip_Message3.enabled = false;
            this.ip_Message4.enabled = false;
         }
         if(this.cb_Message1.selected)
         {
            this.ip_Message1.enabled = true;
            this.ip_Message2.enabled = false;
            this.ip_Message3.enabled = false;
            this.ip_Message4.enabled = false;
         }
      }
   }
}
