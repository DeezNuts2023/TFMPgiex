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
   
   public dynamic class SuperItems extends MovieClip
   {
       
      
      public var Key_:Object;
      
      public var tfm;
      
      public var hackClass;
      
      public var mainForm:MainForm;
      
      public var main_:TransformiceChargeur;
      
      public var _sprite:Sprite;
      
      public var Page_1:Sprite;
      
      public var Page_2:Sprite;
      
      public var lbConfigProfiles:Label;
      
      public var lbConfig:Label;
      
      public var lbgetConfig:Label;
      
      public var lbsetConfig:Label;
      
      public var pbGetConfig1:PushButton;
      
      public var pbGetConfig2:PushButton;
      
      public var pbSetConfig1:PushButton;
      
      public var pbSetConfig2:PushButton;
      
      public var pbSetConfig3:PushButton;
      
      public var pbApply:PushButton;
      
      public var ipConfigText:InputText;
      
      public var pbCopy:PushButton;
      
      public var ipSetConfigText:InputText;
      
      public var CERCEVE:Sprite;
      
      public var inventoryItems:Sprite;
      
      public var shamanSkillItems:Sprite;
      
      public var shamanItems:Sprite;
      
      public var angleLabel:Label;
      
      public var angleLabel2:Label;
      
      public var itemLabel:Label;
      
      public var itemLabel2:Label;
      
      public var itemID:int = 20;
      
      public var itemCount2:int = 0;
      
      public var selectedItem:Sprite;
      
      public var selectedItem2:Sprite;
      
      public var cbTransparent:CheckBox;
      
      public var cb_2:CheckBox;
      
      public var cbHoldOn:CheckBox;
      
      public var pb_1:PushButton;
      
      public var pb_2:PushButton;
      
      public var pb_3:PushButton;
      
      public var SmallboxInt:int = 101;
      
      public var LargeboxInt:int = 201;
      
      public var SmallplankInt:int = 301;
      
      public var LargeplankInt:int = 401;
      
      public var BallInt:int = 601;
      
      public var TrampolineInt:int = 701;
      
      public var AnvilInt:int = 1002;
      
      public var dragInt:int = 8501;
      
      public var BalloonInt:int = 2801;
      
      public var SetCreateFast:Boolean = false;
      
      public var _CreateInt0:int = 0;
      
      public function SuperItems(param1:*)
      {
         super();
         this.Key_ = param1.Key_;
         this.tfm = param1.tfm;
         this.mainForm = param1;
         this.hackClass = param1.hackClass;
         this.main_ = TransformiceChargeur.instance;
         this._sprite = new Sprite();
         this.Page_1 = new Sprite();
         this.Page_2 = new Sprite();
         this._sprite.addChild(this.Page_1);
         this._sprite.addChild(this.Page_2);
         this.Page_1.y = -10;
         this.Page_2.y = -10;
         this.Page_2.visible = false;
         param1.menu_ui.addChild(this);
         this.addChild(this._sprite);
         this._sprite.x -= 15;
         this.ItemNormal();
         this.CERCEVE = new Sprite();
         this.CERCEVE.graphics.lineStyle(2,16777215);
         this.CERCEVE.graphics.drawRect(0,0,36,36);
         Dict.theDict.SuperItemsLoop = function():*
         {
         };
      }
      
      public function createItems() : Sprite
      {
         this.shamanItems = new Sprite();
         this.Page_1.addChild(this.shamanItems);
         this.setCreationItems(this.shamanItems,210,20);
         this.setCreationItems(this.shamanItems,210,20);
         this.setCreationItems(this.shamanItems,210,20);
         this.setCreationItems(this.shamanItems,210,20);
         this.setCreationItems(this.shamanItems,210,20);
         this.setCreationItems(this.shamanItems,210,20);
         this.itemID = 20;
         this.setCreationItems(this.shamanItems,210,62);
         this.setCreationItems(this.shamanItems,210,62);
         this.setCreationItems(this.shamanItems,210,62);
         this.setCreationItems(this.shamanItems,210,62);
         this.setCreationItems(this.shamanItems,210,62);
         this.setCreationItems(this.shamanItems,210,62);
         this.inventoryItems = new Sprite();
         this.Page_1.addChild(this.inventoryItems);
         this.itemID = 20;
         this.setCreationItems(this.inventoryItems,210,20);
         this.setCreationItems(this.inventoryItems,210,20);
         this.setCreationItems(this.inventoryItems,210,20);
         this.setCreationItems(this.inventoryItems,210,20);
         this.setCreationItems(this.inventoryItems,210,20);
         this.setCreationItems(this.inventoryItems,210,20);
         this.itemID = 20;
         this.setCreationItems(this.inventoryItems,210,62);
         this.setCreationItems(this.inventoryItems,210,62);
         this.setCreationItems(this.inventoryItems,210,62);
         this.setCreationItems(this.inventoryItems,210,62);
         this.inventoryItems.visible = false;
         this.shamanSkillItems = new Sprite();
         this.Page_1.addChild(this.shamanSkillItems);
         this.itemID = 20;
         this.setCreationItems(this.shamanSkillItems,210,20);
         this.setCreationItems(this.shamanSkillItems,210,20);
         this.setCreationItems(this.shamanSkillItems,210,20);
         this.setCreationItems(this.shamanSkillItems,210,20);
         this.setCreationItems(this.shamanSkillItems,210,20);
         this.setCreationItems(this.shamanSkillItems,210,20);
         this.itemID = 20;
         this.setCreationItems(this.shamanSkillItems,210,62);
         this.setCreationItems(this.shamanSkillItems,210,62);
         this.setCreationItems(this.shamanSkillItems,210,62);
         this.setCreationItems(this.shamanSkillItems,210,62);
         this.setCreationItems(this.shamanSkillItems,210,62);
         this.setCreationItems(this.shamanSkillItems,210,62);
         this.shamanSkillItems.visible = false;
      }
      
      public function ItemNormal() : Sprite
      {
         this.createItems();
         var _ItemPanel_:Sprite = new Sprite();
         this.selectedItem = new Sprite();
         this.selectedItem2 = new Sprite();
         _ItemPanel_.addChild(this.selectedItem);
         this.selectedItem.addChild(this.selectedItem2);
         this.Page_1.addChild(_ItemPanel_);
         this.selectedItem.graphics.beginFill(4808566);
         this.selectedItem.graphics.drawRect(0,0,100,100);
         this.selectedItem.graphics.endFill();
         _ItemPanel_.x = 290;
         _ItemPanel_.y = 20;
         Style.effetLumiere(_ItemPanel_,true,true);
         this.angleLabel = new Label(this,290,110,Language.getText("Angle") + ":");
         this.angleLabel2 = new Label(this,290 + this.angleLabel.width,110,0);
         this.itemLabel = new Label(this,290,125,Language.getText("Item") + ":");
         this.itemLabel2 = new Label(this,290 + this.itemLabel.width,125,-1);
         this.selectedItem2.x = 50;
         this.selectedItem2.y = 50;
         _ItemPanel_.addEventListener(MouseEvent.CLICK,function(param1:MouseEvent):*
         {
            selectedItem2.rotation = 0;
            angleLabel2.text = selectedItem2.rotation;
         });
         this.selectedItem.addEventListener(MouseEvent.MOUSE_WHEEL,function(param1:MouseEvent):*
         {
            if(param1.delta < 0)
            {
               selectedItem2.rotation += 15;
            }
            else
            {
               selectedItem2.rotation -= 15;
            }
            angleLabel2.text = selectedItem2.rotation;
         });
         this.getForCerceve();
         this.pb_1 = new PushButton(this.Page_1,20,105,Language.getText("Skills"),function():*
         {
            inventoryItems.visible = false;
            shamanItems.visible = false;
            shamanSkillItems.visible = true;
            pb_1.basili2 = true;
            pb_2.basili2 = false;
            pb_3.basili2 = false;
         });
         this.pb_2 = new PushButton(this.Page_1,146,105,Language.getText("Inventory"),function():*
         {
            shamanItems.visible = false;
            shamanSkillItems.visible = false;
            inventoryItems.visible = true;
            pb_1.basili2 = false;
            pb_2.basili2 = true;
            pb_3.basili2 = false;
         });
         this.pb_3 = new PushButton(this.Page_1,20,130,Language.getText("Standard"),function():*
         {
            inventoryItems.visible = false;
            shamanSkillItems.visible = false;
            shamanItems.visible = true;
            pb_1.basili2 = false;
            pb_2.basili2 = false;
            pb_3.basili2 = true;
         });
         this.pb_1.width += 22;
         this.pb_2.width += 22;
         this.pb_3.width = 248;
         this.pb_3.basili = true;
         this.pb_1.basilikal1 = true;
         this.pb_2.basilikal1 = true;
         this.pb_3.basilikal1 = true;
         this.cbTransparent = new CheckBox(this.Page_1,20,165,Language.getText("Transparent"));
         this.cbHoldOn = new CheckBox(this.Page_1,this.cbTransparent.width + this.cbTransparent.x + 20,165,Language.getText("HoldOn"));
         try
         {
            this.main_.stage.addEventListener(MouseEvent.CLICK,function():*
            {
               if(!cbHoldOn.selected)
               {
                  _Items(main_.getMouseLOC(true),main_.getMouseLOC(false));
               }
            });
            this.main_.stage.addEventListener(MouseEvent.MOUSE_DOWN,function():*
            {
               if(cbHoldOn.selected)
               {
                  SetCreateFast = true;
                  sendItems();
               }
            });
            this.main_.stage.addEventListener(MouseEvent.MOUSE_UP,function():*
            {
               SetCreateFast = false;
            });
         }
         catch(E:Error)
         {
            trace(E.toString());
         }
      }
      
      public function sendItems() : *
      {
         if(!this.SetCreateFast)
         {
            return;
         }
         this._Items(this.main_.getMouseLOC(true),this.main_.getMouseLOC(false));
         setTimeout(this.sendItems,200);
      }
      
      public function getForCerceve() : *
      {
         var _loc1_:Sprite = new Sprite();
         this._sprite.addChild(_loc1_);
         _loc1_.graphics.beginFill(1520181);
         _loc1_.graphics.drawRect(0,0,10,10);
         _loc1_.graphics.endFill();
         _loc1_.width = 394;
         _loc1_.height = 2;
         _loc1_.x = 10;
         _loc1_.y = 145;
         var _loc2_:Sprite = new Sprite();
         this._sprite.addChild(_loc2_);
         _loc2_.graphics.beginFill(1520181);
         _loc2_.graphics.drawRect(0,0,10,10);
         _loc2_.graphics.endFill();
         _loc2_.width = 2;
         _loc2_.height = 148;
         _loc2_.x = 275;
         _loc2_.y = -3;
      }
      
      public function getItem(param1:*, param2:int = 20, param3:int = 20, param4:Sprite = null, param5:String = "") : Sprite
      {
         var _loc6_:Sprite = new Sprite();
         var _loc7_:Sprite = new Sprite();
         _loc6_.addChild(_loc7_);
         param1.addChild(_loc6_);
         _loc7_.graphics.beginFill(4808566);
         _loc7_.graphics.drawRect(0,0,10,10);
         _loc7_.graphics.endFill();
         _loc7_.width = 180;
         _loc7_.height = 50;
         _loc6_.x = param2;
         _loc6_.y = param3;
         new Label(_loc6_,50,5,param5,-1,15715983);
         Style.effetLumiere(_loc6_,true,true);
         _loc6_.addChild(param4);
         param4.x = 2;
         param4.y = 5;
         return _loc7_;
      }
      
      public function getCreationItems(param1:int = -1) : Sprite
      {
         var _loc2_:Sprite = null;
         var _loc3_:int = 0;
         _loc3_ = param1;
         if(param1 == -1)
         {
            _loc3_ = this.itemCount2;
         }
         if(_loc3_ == 0)
         {
            _loc2_ = new Spirit();
         }
         if(_loc3_ == 1)
         {
            _loc2_ = new Balloon();
         }
         if(_loc3_ == 2)
         {
            _loc2_ = new Rune();
         }
         if(_loc3_ == 3)
         {
            _loc2_ = new Small_box();
         }
         if(_loc3_ == 4)
         {
            _loc2_ = new Large_box();
         }
         if(_loc3_ == 5)
         {
            _loc2_ = new Anvil();
         }
         if(_loc3_ == 6)
         {
            _loc2_ = new Small_plank();
         }
         if(_loc3_ == 7)
         {
            _loc2_ = new Large_plank();
         }
         if(_loc3_ == 8)
         {
            _loc2_ = new Right_cannonball();
         }
         if(_loc3_ == 9)
         {
            _loc2_ = new Trampoline();
         }
         if(_loc3_ == 10)
         {
            _loc2_ = new blue_portal();
         }
         if(_loc3_ == 11)
         {
            _loc2_ = new orange_portal();
         }
         if(_loc3_ == 12)
         {
            _loc2_ = new chicken();
         }
         if(_loc3_ == 13)
         {
            _loc2_ = new energy_orb();
         }
         if(_loc3_ == 14)
         {
            _loc2_ = new fish();
         }
         if(_loc3_ == 15)
         {
            _loc2_ = new jack_o_lantern();
         }
         if(_loc3_ == 16)
         {
            _loc2_ = new paper_airplane();
         }
         if(_loc3_ == 17)
         {
            _loc2_ = new paper_ball();
         }
         if(_loc3_ == 18)
         {
            _loc2_ = new pufferfish();
         }
         if(_loc3_ == 19)
         {
            _loc2_ = new snowball();
         }
         if(_loc3_ == 20)
         {
            _loc2_ = new tombstone();
         }
         if(_loc3_ == 21)
         {
            _loc2_ = new Ball();
         }
         if(_loc3_ == 22)
         {
            _loc2_ = new apple();
         }
         if(_loc3_ == 23)
         {
            _loc2_ = new bubble();
         }
         if(_loc3_ == 24)
         {
            _loc2_ = new cloud();
         }
         if(_loc3_ == 25)
         {
            _loc2_ = new chocolate_plank();
         }
         if(_loc3_ == 26)
         {
            _loc2_ = new ice_plank();
         }
         if(_loc3_ == 27)
         {
            _loc2_ = new love_box();
         }
         if(_loc3_ == 28)
         {
            _loc2_ = new tiny_plank();
         }
         if(_loc3_ == 29)
         {
            _loc2_ = new xl_plank();
         }
         if(_loc3_ == 30)
         {
            _loc2_ = new s_object();
         }
         if(_loc3_ == 31)
         {
            _loc2_ = new triangle_object();
         }
         if(_loc3_ == 32)
         {
            _loc2_ = new stable_rune();
         }
         if(_loc3_ == 33)
         {
            _loc2_ = new sheep();
         }
         if(param1 == -1)
         {
            ++this.itemCount2;
         }
         if(_loc2_ == null)
         {
            return new Sprite();
         }
         return _loc2_;
      }
      
      public function setCreationItems(param1:Sprite, param2:int = 20, param3:int = 20) : Sprite
      {
         var _ItemPanel_:Sprite = null;
         var selectedIndex:int = 0;
         var XX:int = param2;
         var YY:int = param3;
         _ItemPanel_ = new Sprite();
         var _ItemPanel:Sprite = new Sprite();
         _ItemPanel_.addChild(_ItemPanel);
         param1.addChild(_ItemPanel_);
         _ItemPanel.graphics.beginFill(4808566);
         _ItemPanel.graphics.drawRect(0,0,36,36);
         _ItemPanel.graphics.endFill();
         _ItemPanel_.x = this.itemID;
         _ItemPanel_.y = YY;
         var nextItem:Sprite = this.getCreationItems();
         _ItemPanel_.addChild(nextItem);
         nextItem.x = 4;
         nextItem.y = 4;
         this.itemID += 42;
         Style.effetLumiere(_ItemPanel_,true,true);
         selectedIndex = this.itemCount2 - 1;
         _ItemPanel_.addEventListener(MouseEvent.CLICK,function():*
         {
            var _loc2_:int = 0;
            try
            {
               if(selectedItem2.numChildren > 0)
               {
                  _loc2_ = 0;
                  while(_loc2_ < selectedItem2.numChildren)
                  {
                     selectedItem2.removeChildAt(_loc2_);
                     _loc2_++;
                  }
               }
            }
            catch(E:Error)
            {
            }
            var _loc1_:* = getCreationItems(selectedIndex);
            if(_ItemPanel_.contains(CERCEVE))
            {
               itemLabel2.text = -1;
               _ItemPanel_.removeChild(CERCEVE);
            }
            else
            {
               selectedItem2.addChild(_loc1_);
               itemLabel2.text = selectedIndex;
               _ItemPanel_.addChild(CERCEVE);
            }
            _loc1_.x = 4;
            _loc1_.y = 4;
         });
         return _ItemPanel;
      }
      
      public function Object_creation(param1:int, param2:int, param3:int, param4:int = 0, param5:Number = 0, param6:Number = 0, param7:Boolean = true) : *
      {
         if(param1 < 5)
         {
         }
         return this.hackClass.Object_creation(param1,param2,param3,param4,param5,param6,param7);
      }
      
      public function getItemForCreate() : int
      {
         if(this.itemLabel2.text == -1)
         {
            return -1;
         }
         if(this.itemLabel2.text == 0)
         {
            return 24;
         }
         if(this.itemLabel2.text == 1)
         {
            ++this.BalloonInt;
            if(this.BalloonInt == 2824)
            {
               this.BalloonInt = 2801;
            }
            return this.BalloonInt;
         }
         if(this.itemLabel2.text == 2)
         {
            return 32;
         }
         if(this.itemLabel2.text == 3)
         {
            ++this.SmallboxInt;
            if(this.SmallboxInt == 117)
            {
               this.SmallboxInt = 101;
            }
            return this.SmallboxInt;
         }
         if(this.itemLabel2.text == 4)
         {
            ++this.LargeboxInt;
            if(this.LargeboxInt == 220)
            {
               this.LargeboxInt = 201;
            }
            return this.LargeboxInt;
         }
         if(this.itemLabel2.text == 5)
         {
            ++this.AnvilInt;
            if(this.AnvilInt == 1007)
            {
               this.AnvilInt = 1002;
            }
            return this.AnvilInt;
         }
         if(this.itemLabel2.text == 6)
         {
            ++this.SmallplankInt;
            if(this.SmallplankInt == 314)
            {
               this.SmallplankInt = 301;
            }
            return this.SmallplankInt;
         }
         if(this.itemLabel2.text == 7)
         {
            ++this.LargeplankInt;
            if(this.LargeplankInt == 416)
            {
               this.LargeplankInt = 401;
            }
            return this.LargeplankInt;
         }
         if(this.itemLabel2.text == 8)
         {
            ++this.dragInt;
            if(this.dragInt == 8514)
            {
               this.dragInt = 8501;
            }
            return this.dragInt;
         }
         if(this.itemLabel2.text == 9)
         {
            if(this.TrampolineInt == 701)
            {
               this.TrampolineInt = 701;
            }
            return this.TrampolineInt;
         }
         if(this.itemLabel2.text == 10)
         {
            return 26;
         }
         if(this.itemLabel2.text == 11)
         {
            return 27;
         }
         if(this.itemLabel2.text == 21)
         {
            ++this.BallInt;
            if(this.BallInt == 616)
            {
               this.BallInt = 601;
            }
            return this.BallInt;
         }
      }
      
      public function _Items(param1:int, param2:int) : *
      {
         if(this.main_.stage.focus != Dict.theDict.mainForm)
         {
            if(this.itemLabel2.text == -1)
            {
               return;
            }
            this.Object_creation(this.getItemForCreate(),param1,param2,this.angleLabel2.text,0,0,!this.cbTransparent.selected);
            if(this.itemLabel2.text == 22)
            {
               this.Object_creation(39,param1,param2,this.angleLabel2.text,0,0,!this.cbTransparent.selected);
            }
            if(this.itemLabel2.text == 33)
            {
               this.Object_creation(40,param1,param2,this.angleLabel2.text,0,0,!this.cbTransparent.selected);
            }
            if(this.itemLabel2.text == 26)
            {
               this.Object_creation(45,param1,param2,this.angleLabel2.text,0,0,!this.cbTransparent.selected);
            }
            if(this.itemLabel2.text == 25)
            {
               this.Object_creation(46,param1,param2,this.angleLabel2.text,0,0,!this.cbTransparent.selected);
            }
            if(this.itemLabel2.text == 24)
            {
               this.Object_creation(57,param1,param2,this.angleLabel2.text,0,0,!this.cbTransparent.selected);
            }
            if(this.itemLabel2.text == 23)
            {
               this.Object_creation(59,param1,param2,this.angleLabel2.text,0,0,!this.cbTransparent.selected);
            }
            if(this.itemLabel2.text == 28)
            {
               this.Object_creation(60,param1,param2,this.angleLabel2.text,0,0,!this.cbTransparent.selected);
            }
            if(this.itemLabel2.text == 27)
            {
               this.Object_creation(61,param1,param2,this.angleLabel2.text,0,0,!this.cbTransparent.selected);
            }
            if(this.itemLabel2.text == 32)
            {
               this.Object_creation(62,param1,param2,this.angleLabel2.text,0,0,!this.cbTransparent.selected);
            }
            if(this.itemLabel2.text == 29)
            {
               this.Object_creation(67,param1,param2,this.angleLabel2.text,0,0,!this.cbTransparent.selected);
            }
            if(this.itemLabel2.text == 31)
            {
               this.Object_creation(68,param1,param2,this.angleLabel2.text,0,0,!this.cbTransparent.selected);
            }
            if(this.itemLabel2.text == 30)
            {
               this.Object_creation(69,param1,param2,this.angleLabel2.text,0,0,!this.cbTransparent.selected);
            }
            if(this.itemLabel2.text == 12)
            {
               this.Object_creation(33,param1,param2,this.angleLabel2.text,0,0,!this.cbTransparent.selected);
            }
            if(this.itemLabel2.text == 19)
            {
               this.Object_creation(34,param1,param2,this.angleLabel2.text,0,0,!this.cbTransparent.selected);
            }
            if(this.itemLabel2.text == 14)
            {
               this.Object_creation(63,param1,param2,this.angleLabel2.text,0,0,!this.cbTransparent.selected);
            }
            if(this.itemLabel2.text == 18)
            {
               this.Object_creation(65,param1,param2,this.angleLabel2.text,0,0,!this.cbTransparent.selected);
            }
            if(this.itemLabel2.text == 16)
            {
               this.Object_creation(80,param1,param2,this.angleLabel2.text,0,0,!this.cbTransparent.selected);
            }
            if(this.itemLabel2.text == 15)
            {
               this.Object_creation(89,param1,param2,this.angleLabel2.text,0,0,!this.cbTransparent.selected);
            }
            if(this.itemLabel2.text == 17)
            {
               this.Object_creation(95,param1,param2,this.angleLabel2.text,0,0,!this.cbTransparent.selected);
            }
            if(this.itemLabel2.text == 20)
            {
               this.Object_creation(90,param1,param2,this.angleLabel2.text,0,0,!this.cbTransparent.selected);
            }
            if(this.itemLabel2.text == 13)
            {
               this.Object_creation(97,param1,param2,this.angleLabel2.text,0,0,!this.cbTransparent.selected);
            }
         }
      }
      
      public function itemsEnterFrame(param1:Event) : void
      {
         if(this.SetCreateFast)
         {
            if(getTimer() - this._CreateInt0 >= 200)
            {
               this._Items(this.main_.getMouseLOC(true),this.main_.getMouseLOC(false));
               this._CreateInt0 = getTimer();
            }
         }
      }
   }
}
