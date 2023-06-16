package coms.bit101.components
{
   import ChargeurTransformice_fla.*;
   import flash.display.*;
   import flash.events.*;
   import flash.filters.*;
   
   public class CheckBox extends Component
   {
      
      private static var filtreCheckBox:Array = new Array(new BevelFilter(1,45,0,1,6325657,1,1,1,1,3));
       
      
      protected var _back:Sprite;
      
      protected var _button:Sprite;
      
      protected var _label:Label;
      
      protected var _labelText:String = "";
      
      protected var _selected:Boolean = false;
      
      public var tik1:Sprite;
      
      public var tik2:Sprite;
      
      public var tik3:Sprite;
      
      public var newCheckbox:Boolean;
      
      public var colorC:int = -1;
      
      public function CheckBox(param1:DisplayObjectContainer = null, param2:Number = 0, param3:Number = 0, param4:String = "", param5:Function = null, param6:Boolean = true, param7:Boolean = false)
      {
         this._labelText = param4;
         if(param6)
         {
            this.newCheckbox = param6;
            Style.effetLumiere(this,true,true);
         }
         if(param7)
         {
            this.colorC = 1498111;
         }
         super(param1,param2,param3);
         if(param5 != null)
         {
            addEventListener(MouseEvent.CLICK,param5);
         }
      }
      
      override protected function init() : void
      {
         super.init();
         buttonMode = true;
         useHandCursor = true;
         mouseChildren = false;
      }
      
      override protected function addChildren() : void
      {
         this._back = new Sprite();
         this._back.graphics.beginFill(2306616);
         if(this.newCheckbox)
         {
            this._back.graphics.drawRect(1,1,14,14);
         }
         else
         {
            this._back.graphics.drawCircle(6,6,6);
         }
         this._back.graphics.endFill();
         this._back.filters = filtreCheckBox;
         addChild(this._back);
         if(this.newCheckbox)
         {
            this.tik1 = new Sprite();
            this.tik1.graphics.beginFill(11059144);
            this.tik1.graphics.drawRoundRect(1,1,6,2,3);
            this.tik1.rotation = 45;
            this.tik1.graphics.endFill();
            this.tik2 = new Sprite();
            this.tik2.graphics.beginFill(11059144);
            this.tik2.graphics.drawRoundRect(0,0,12,2,4);
            this.tik2.rotation = 125;
            this._button = new Sprite();
            this._button.addChild(this.tik1);
            this._button.addChild(this.tik2);
            this.tik2.x += 10;
            this.tik2.y -= 2;
            this._button.x += 4;
            this._button.y += 6;
            --this._button.width;
            --this._button.height;
         }
         else
         {
            this._button = new Sprite();
            this._button.graphics.beginFill(11059144);
            this._button.graphics.drawCircle(6,6,3);
         }
         this._button.visible = false;
         addChild(this._button);
         this._label = new Label(this,20,10,this._labelText,-1,this.colorC);
         this.draw();
         addEventListener(MouseEvent.CLICK,this.onClick);
      }
      
      override public function draw() : void
      {
         super.draw();
         this._label.text = this._labelText;
         this._label.draw();
         if(this.newCheckbox)
         {
            this._label.x = 18;
            this._label.y = -1;
         }
         else
         {
            this._label.x = 13;
            this._label.y = (12 - this._label.height) / 2;
         }
         _width = this._label.width + 12;
         _height = 10;
      }
      
      protected function onClick(param1:MouseEvent) : void
      {
         this._selected = !this._selected;
         this._button.visible = this._selected;
      }
      
      public function set label(param1:String) : void
      {
         this._labelText = param1;
         invalidate();
      }
      
      public function get label() : String
      {
         return this._labelText;
      }
      
      public function set selected(param1:Boolean) : void
      {
         this._selected = param1;
         this._button.visible = this._selected;
      }
      
      public function get selected() : Boolean
      {
         return this._selected;
      }
      
      override public function set enabled(param1:Boolean) : void
      {
         super.enabled = param1;
         mouseChildren = false;
      }
   }
}
