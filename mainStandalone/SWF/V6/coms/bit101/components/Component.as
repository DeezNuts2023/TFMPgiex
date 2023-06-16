package coms.bit101.components
{
   import ChargeurTransformice_fla.*;
   import flash.display.*;
   import flash.events.*;
   import flash.filters.*;
   
   public class Component extends Sprite
   {
      
      public static const DRAW:String = "draw";
       
      
      protected var _width:Number = 0;
      
      protected var _height:Number = 0;
      
      protected var _tag:int = -1;
      
      protected var _enabled:Boolean = true;
      
      public var userData:Object;
      
      public function Component(param1:DisplayObjectContainer = null, param2:Number = 0, param3:Number = 0)
      {
         super();
         this.move(param2,param3);
         this.init();
         if(param1 != null)
         {
            param1.addChild(this);
         }
      }
      
      public static function initStage(param1:Stage) : void
      {
         param1.align = StageAlign.TOP_LEFT;
         param1.scaleMode = StageScaleMode.NO_SCALE;
      }
      
      protected function init() : void
      {
         this.addChildren();
         this.invalidate();
      }
      
      protected function addChildren() : void
      {
      }
      
      protected function getShadow(param1:Number, param2:Boolean = false) : DropShadowFilter
      {
         return new DropShadowFilter(param1,45,Style.DROPSHADOW,1,param1,param1,0.3,1,param2);
      }
      
      protected function invalidate() : void
      {
         addEventListener(Event.ENTER_FRAME,this.onInvalidate);
      }
      
      public function move(param1:Number, param2:Number) : void
      {
         this.x = Math.round(param1);
         this.y = Math.round(param2);
      }
      
      public function setSize(param1:Number, param2:Number) : void
      {
         this._width = param1;
         this._height = param2;
         dispatchEvent(new Event(Event.RESIZE));
         this.invalidate();
      }
      
      public function draw() : void
      {
         dispatchEvent(new Event(Component.DRAW));
      }
      
      protected function onInvalidate(param1:Event) : void
      {
         removeEventListener(Event.ENTER_FRAME,this.onInvalidate);
         this.draw();
      }
      
      override public function set width(param1:Number) : void
      {
         this._width = param1;
         this.invalidate();
         dispatchEvent(new Event(Event.RESIZE));
      }
      
      override public function get width() : Number
      {
         return this._width;
      }
      
      override public function set height(param1:Number) : void
      {
         this._height = param1;
         this.invalidate();
         dispatchEvent(new Event(Event.RESIZE));
      }
      
      override public function get height() : Number
      {
         return this._height;
      }
      
      public function set tag(param1:int) : void
      {
         this._tag = param1;
      }
      
      public function get tag() : int
      {
         return this._tag;
      }
      
      override public function set x(param1:Number) : void
      {
         super.x = Math.round(param1);
      }
      
      override public function set y(param1:Number) : void
      {
         super.y = Math.round(param1);
      }
      
      public function set enabled(param1:Boolean) : void
      {
         this._enabled = param1;
         var _loc_2:* = this._enabled;
         mouseChildren = this._enabled;
         mouseEnabled = _loc_2;
         tabEnabled = param1;
         alpha = !!this._enabled ? Number(Number(1)) : Number(Number(0.5));
         this.addEventListener(MouseEvent.MOUSE_OUT,function(param1:*):*
         {
            this._enabled = param1;
            var _loc2_:* = this._enabled;
            mouseChildren = this._enabled;
            mouseEnabled = _loc2_;
            tabEnabled = param1;
            alpha = !!this._enabled ? Number(Number(1)) : Number(Number(0.5));
         });
      }
      
      public function get enabled() : Boolean
      {
         return this._enabled;
      }
   }
}
