package com.bit101.components
{
   import flash.display.*;
   import flash.events.*;
   
   public class PushButton extends Component
   {
       
      
      protected var _back:Sprite;
      
      protected var _face:Sprite;
      
      protected var _label:Label;
      
      protected var _labelText:String = "";
      
      protected var _over:Boolean = false;
      
      protected var _down:Boolean = false;
      
      protected var _selected:Boolean = false;
      
      protected var _toggle:Boolean = false;
      
      public function PushButton(param1:DisplayObjectContainer = null, param2:Number = 0, param3:Number = 0, param4:String = "", param5:Function = null)
      {
         super(param1,param2,param3);
         if(param5 != null)
         {
            addEventListener(MouseEvent.CLICK,param5);
         }
         this.label = param4;
         Style.effetLumiere(this,true,true);
      }
      
      override protected function init() : void
      {
         super.init();
         buttonMode = true;
         useHandCursor = true;
         setSize(100,20);
      }
      
      override protected function addChildren() : void
      {
         this._back = new Sprite();
         this._back.mouseEnabled = false;
         addChild(this._back);
         this._face = new Sprite();
         this._face.mouseEnabled = false;
         this._face.x = 1;
         this._face.y = 1;
         if(this._back)
         {
            this._back.x = 1;
            this._back.y = 1;
         }
         addChild(this._face);
         this._label = new Label();
         addChild(this._label);
         addEventListener(MouseEvent.MOUSE_DOWN,this.onMouseGoDown);
         addEventListener(MouseEvent.ROLL_OVER,this.onMouseOver);
      }
      
      protected function drawFace() : void
      {
         this._face.graphics.clear();
         if(this._down)
         {
            this._face.graphics.beginFill(Style.BUTTON_DOWN);
            this._face.filters = Style.FILTRE_BOUTON_ENFONCE;
         }
         else
         {
            this._face.graphics.beginFill(Style.BUTTON_FACE);
            this._face.filters = Style.FILTRE_BOUTON;
         }
         this._face.graphics.drawRoundRect(0,0,_width - 2,_height - 2,6);
         this._face.graphics.endFill();
      }
      
      override public function draw() : void
      {
         super.draw();
         this.drawFace();
         if(this._labelText != "")
         {
            this._label.text = this._labelText;
            this._label.autoSize = true;
            this._label.draw();
            if(this._label.width > _width - 4)
            {
               this._label.autoSize = false;
               this._label.width = _width - 4;
            }
            else
            {
               this._label.autoSize = true;
            }
            this._label.draw();
            this._label.move(_width / 2 - this._label.width / 2,_height / 2 - this._label.height / 2);
         }
      }
      
      protected function onMouseOver(param1:MouseEvent) : void
      {
         this._over = true;
         addEventListener(MouseEvent.ROLL_OUT,this.onMouseOut);
         invalidate();
      }
      
      protected function onMouseOut(param1:MouseEvent) : void
      {
         this._over = false;
         removeEventListener(MouseEvent.ROLL_OUT,this.onMouseOut);
         invalidate();
      }
      
      protected function onMouseGoDown(param1:MouseEvent) : void
      {
         this._down = true;
         this.drawFace();
         stage.addEventListener(MouseEvent.MOUSE_UP,this.onMouseGoUp);
      }
      
      protected function onMouseGoUp(param1:MouseEvent) : void
      {
         if(this._toggle && this._over)
         {
            this._selected = !this._selected;
         }
         this._down = this._selected;
         this.drawFace();
         stage.removeEventListener(MouseEvent.MOUSE_UP,this.onMouseGoUp);
      }
      
      public function set label(param1:String) : void
      {
         this._labelText = param1;
         this.draw();
      }
      
      public function get label() : String
      {
         return this._labelText;
      }
      
      public function set selected(param1:Boolean) : void
      {
         if(!this._toggle)
         {
            param1 = false;
         }
         this._selected = param1;
         this._down = this._selected;
         this.drawFace();
      }
      
      public function get selected() : Boolean
      {
         return this._selected;
      }
      
      public function set toggle(param1:Boolean) : void
      {
         this._toggle = param1;
      }
      
      public function get toggle() : Boolean
      {
         return this._toggle;
      }
   }
}
