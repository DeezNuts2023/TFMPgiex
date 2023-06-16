package coms.bit101.components
{
   import ChargeurTransformice_fla.*;
   import flash.display.*;
   import flash.events.*;
   import flash.text.*;
   
   public class Label extends Component
   {
       
      
      protected var _autoSize:Boolean = true;
      
      protected var _text:String = "";
      
      public var _tf:TextField;
      
      protected var _align:String;
      
      private var _html:Boolean = false;
      
      protected var _backgroundColor:int;
      
      protected var _fontColor:int;
      
      public function Label(param1:DisplayObjectContainer = null, param2:Number = 0, param3:Number = 0, param4:String = "", param5:int = -1, param6:int = -1, param7:String = "")
      {
         this._backgroundColor = param5;
         this._fontColor = param6;
         this.text = param4;
         this._align = param7 == "" ? TextFormatAlign.LEFT : param7;
         super(param1,param2,param3);
      }
      
      public function formatage(param1:TextFormat) : void
      {
         this._tf.defaultTextFormat = param1;
      }
      
      override protected function init() : void
      {
         super.init();
         mouseEnabled = false;
         mouseChildren = false;
      }
      
      override protected function addChildren() : void
      {
         _height = 18;
         this._tf = new TextField();
         this._tf.height = _height;
         this._tf.embedFonts = Style.embedFonts;
         this._tf.selectable = false;
         this._tf.mouseEnabled = false;
         var _loc1_:* = new TextFormat(Style.x_policeInterface,Style.fontSize,this._fontColor == -1 ? Style.COULEUR_TEXTE_DEFAUT : this._fontColor);
         _loc1_.align = this._align;
         this._tf.defaultTextFormat = _loc1_;
         if(this._html)
         {
            this._tf.htmlText = this._text;
         }
         else
         {
            this._tf.text = this._text;
         }
         addChild(this._tf);
         this.draw();
      }
      
      override public function draw() : void
      {
         super.draw();
         if(this._backgroundColor != -1)
         {
            graphics.clear();
            graphics.beginFill(this._backgroundColor);
            graphics.drawRect(0,0,width,height);
            graphics.endFill();
         }
         if(this._html)
         {
            this._tf.htmlText = this._text;
         }
         else
         {
            this._tf.text = this._text;
         }
         if(this._autoSize)
         {
            this._tf.autoSize = TextFieldAutoSize.LEFT;
            _width = this._tf.width;
            dispatchEvent(new Event(Event.RESIZE));
         }
         else
         {
            this._tf.autoSize = TextFieldAutoSize.NONE;
            this._tf.width = _width;
         }
         var _loc1_:int = 18;
         this._tf.height = 18;
         _height = _loc1_;
      }
      
      public function set text(param1:String) : void
      {
         this._text = param1;
         if(this._text == null)
         {
            this._text = "";
         }
         invalidate();
      }
      
      public function get text() : String
      {
         return this._text;
      }
      
      public function get html() : Boolean
      {
         return this._html;
      }
      
      public function set html(param1:Boolean) : void
      {
         this._html = param1;
         if(this._html)
         {
            mouseEnabled = true;
            mouseChildren = true;
            this._tf.mouseEnabled = true;
         }
      }
      
      public function set stylesheet(param1:StyleSheet) : void
      {
         if(this._html)
         {
            this._tf.styleSheet = param1;
         }
      }
      
      public function set autoSize(param1:Boolean) : void
      {
         this._autoSize = param1;
      }
      
      public function get autoSize() : Boolean
      {
         return this._autoSize;
      }
      
      public function get textField() : TextField
      {
         return this._tf;
      }
      
      public function changementCouleur(param1:int) : void
      {
         this._tf.textColor = param1;
      }
   }
}
