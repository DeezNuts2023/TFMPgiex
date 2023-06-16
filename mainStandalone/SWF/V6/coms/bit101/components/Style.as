package coms.bit101.components
{
   import ChargeurTransformice_fla.*;
   import flash.display.*;
   import flash.events.*;
   import flash.filters.*;
   import flash.geom.*;
   import flash.text.*;
   
   public class Style
   {
      
      public static var TEXT_BACKGROUND:uint = 16777215;
      
      public static var BACKGROUND:uint = 13421772;
      
      public static var BUTTON_FACE:uint = 3952740;
      
      public static var BUTTON_DOWN:uint = 2438461;
      
      public static var FILTRE_BOUTON:Array = new Array(new BevelFilter(1,45,6126992,1,0,1,1,1,1));
      
      public static var FILTRE_BOUTON_ENFONCE:Array = new Array(new BevelFilter(1,45,0,1,6126992,1,1,1,1));
      
      public static var EFFET_BISEAU_FENETRE:Array = new Array(new BevelFilter(1,45,6983586,1,0,1,1,1,1));
      
      public static var FOND_TITRE_FENETRE:int = 2570047;
      
      public static var FOND_FENETRE:int = 3294800;
      
      public static var TEXTE_TITRE_FENETRE:TextFormat = new TextFormat("Tahoma",16,40349,true);
      
      public static var COULEUR_TEXTE_SAISIE:int = 4513245;
      
      public static var COULEUR_FOND_TEXTE_SAISIE:int = 3952740;
      
      public static var FILTRE_FOND_SAISIE:Array = new Array(new BevelFilter(1,45,0,1,6126992,1,1,1,1));
      
      public static var INPUT_TEXT:uint = 3355443;
      
      public static var COULEUR_TEXTE_DEFAUT:uint = 12763866;
      
      public static var DROPSHADOW:uint = 0;
      
      public static var PANEL:uint = 15987699;
      
      public static var PROGRESS_BAR:uint = 16777215;
      
      public static var LIST_DEFAULT:uint = 16777215;
      
      public static var LIST_ALTERNATE:uint = 15987699;
      
      public static var LIST_SELECTED:uint = 13421772;
      
      public static var LIST_ROLLOVER:uint = 14540253;
      
      public static var SCROLLBAR_MARGIN:int = 1;
      
      public static var SCROLLBAR_SIZE:int = 10;
      
      public static var embedFonts:Boolean = false;
      
      public static var x_policeInterface:String = "Verdana";
      
      public static var fontSize:Number = 11;
      
      public static const DARK:String = "dark";
      
      public static const LIGHT:String = "light";
      
      public static const TRANSFORMICE:String = "transformice";
      
      public static const MODOPWET:String = "pwet";
      
      public static var GLOBAL_STYLESHEET:StyleSheet = new StyleSheet();
      
      private static const couleurLumiere:ColorTransform = new ColorTransform(1.3,1.3,1.3);
      
      private static const couleurNormal:ColorTransform = new ColorTransform();
       
      
      public function Style()
      {
         super();
      }
      
      public static function initialisationStyle() : void
      {
         GLOBAL_STYLESHEET.setStyle("a:hover",{"color":"#2ECF73"});
         GLOBAL_STYLESHEET.setStyle("a:active",{"color":"#2ECF73"});
         GLOBAL_STYLESHEET.setStyle("BL",{"color":"#6C77C1"});
         GLOBAL_STYLESHEET.setStyle("BV",{"color":"#2F7FCC"});
         GLOBAL_STYLESHEET.setStyle("CE",{"color":"#E88F4F"});
         GLOBAL_STYLESHEET.setStyle("CEP",{"color":"#F0A78E"});
         GLOBAL_STYLESHEET.setStyle("CH",{"color":"#98E2EB"});
         GLOBAL_STYLESHEET.setStyle("CS",{"color":"#EFCE8F"});
         GLOBAL_STYLESHEET.setStyle("G",{"color":"#60608F"});
         GLOBAL_STYLESHEET.setStyle("J",{"color":"#BABD2F"});
         GLOBAL_STYLESHEET.setStyle("N",{"color":"#C2C2DA"});
         GLOBAL_STYLESHEET.setStyle("N2",{"color":"#9292AA"});
         GLOBAL_STYLESHEET.setStyle("PT",{"color":"#2EBA7E"});
         GLOBAL_STYLESHEET.setStyle("PS",{"color":"#F1C4F6"});
         GLOBAL_STYLESHEET.setStyle("R",{"color":"#CB546B"});
         GLOBAL_STYLESHEET.setStyle("ROSE",{"color":"#ED67EA"});
         GLOBAL_STYLESHEET.setStyle("S",{"color":"#CAA4CF"});
         GLOBAL_STYLESHEET.setStyle("T",{"color":"#A4CF9E"});
         GLOBAL_STYLESHEET.setStyle("TD",{"textAlign":"right"});
         GLOBAL_STYLESHEET.setStyle("TG",{"textAlign":"left"});
         GLOBAL_STYLESHEET.setStyle("TI",{"fontSize":"14"});
         GLOBAL_STYLESHEET.setStyle("V",{"color":"#009D9D"});
         GLOBAL_STYLESHEET.setStyle("VP",{"color":"#2ECF73"});
         GLOBAL_STYLESHEET.setStyle("VI",{"color":"#C53DFF"});
      }
      
      public static function setStyle(param1:String) : void
      {
         switch(param1)
         {
            case TRANSFORMICE:
               Style.embedFonts = false;
               Style.fontSize = 11;
               Style.COULEUR_TEXTE_DEFAUT = 12763866;
               Style.BACKGROUND = 3294800;
               Style.TEXT_BACKGROUND = 3294800;
               Style.PANEL = 3294800;
               Style.BUTTON_FACE = 3952740;
               Style.BUTTON_DOWN = 2438461;
               Style.SCROLLBAR_MARGIN = 0;
               Style.SCROLLBAR_SIZE = 4;
               Style.LIST_DEFAULT = 3294800;
               Style.LIST_SELECTED = 2514011;
               Style.LIST_ROLLOVER = 2511196;
               break;
            case MODOPWET:
               Style.fontSize = 10;
               Style.COULEUR_TEXTE_DEFAUT = 40349;
               Style.BUTTON_FACE = 0;
               Style.BUTTON_DOWN = 0;
               Style.LIST_DEFAULT = 1118481;
               Style.LIST_SELECTED = 2236962;
               Style.LIST_ROLLOVER = 4473924;
               break;
            case DARK:
               Style.BACKGROUND = 4473924;
               Style.BUTTON_FACE = 6710886;
               Style.BUTTON_DOWN = 2236962;
               Style.INPUT_TEXT = 12303291;
               Style.COULEUR_TEXTE_DEFAUT = 13421772;
               Style.PANEL = 6710886;
               Style.PROGRESS_BAR = 6710886;
               Style.TEXT_BACKGROUND = 5592405;
               Style.LIST_DEFAULT = 4473924;
               Style.LIST_ALTERNATE = 3750201;
               Style.LIST_SELECTED = 6710886;
               Style.LIST_ROLLOVER = 7829367;
               break;
            case LIGHT:
            default:
               Style.BACKGROUND = 13421772;
               Style.BUTTON_FACE = 16777215;
               Style.BUTTON_DOWN = 15658734;
               Style.INPUT_TEXT = 3355443;
               Style.COULEUR_TEXTE_DEFAUT = 6710886;
               Style.PANEL = 15987699;
               Style.PROGRESS_BAR = 16777215;
               Style.TEXT_BACKGROUND = 16777215;
               Style.LIST_DEFAULT = 16777215;
               Style.LIST_ALTERNATE = 15987699;
               Style.LIST_SELECTED = 13421772;
               Style.LIST_ROLLOVER = 14540253;
         }
      }
      
      public static function effetLumiere(param1:Sprite, param2:Boolean, param3:Boolean = false) : void
      {
         if(param2)
         {
            param1.addEventListener(MouseEvent.MOUSE_OVER,lumiereSouris1);
            param1.addEventListener(MouseEvent.MOUSE_OUT,lumiereSouris2);
            if(param3)
            {
               param1.useHandCursor = true;
               param1.buttonMode = true;
            }
         }
         else
         {
            param1.removeEventListener(MouseEvent.MOUSE_OVER,lumiereSouris1);
            param1.removeEventListener(MouseEvent.MOUSE_OUT,lumiereSouris2);
            param1.transform.colorTransform = couleurNormal;
            param1.useHandCursor = false;
            param1.buttonMode = false;
         }
      }
      
      private static function lumiereSouris1(param1:MouseEvent) : void
      {
         var _loc2_:* = param1.currentTarget as Sprite;
         _loc2_.transform.colorTransform = couleurLumiere;
      }
      
      private static function lumiereSouris2(param1:MouseEvent) : void
      {
         var _loc2_:* = param1.currentTarget as Sprite;
         _loc2_.transform.colorTransform = couleurNormal;
      }
   }
}
