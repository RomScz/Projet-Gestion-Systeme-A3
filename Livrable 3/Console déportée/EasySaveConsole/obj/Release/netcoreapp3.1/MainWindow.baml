   M S B A M L   `   `   `  ????   EasySaveConsole     EasySaveConsole.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aGmaterialDesigin1http://materialdesigninxaml.net/winfx/xaml/themes    ? Title$  
MainWindow??$	??360??$	??750?? ? 
ResizeMode$ NoResize=? ? WindowStyle$
 None=?????  ?? Color$ 	#FF2B3545??.???  ? RowDefinitions ?? $??30 ???  ? ColumnDefinitions ?? $	??200 ??? $??* ?.+?? $??1??????  ?? EndPoint$ 0.5,1&? ?? 
StartPoint$ 0.5,0&?.???  ? Color$ 	#FF044F6F??	 ? Offset$	 1Q?? $ 	#FF0BABF1??$	 0Q? ?? $	??100 ??? $??* ?
 J? Effect
 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 20Q?   Color$ 	#FF77D1F7??   RenderingBias$ Quality=?   ShadowDepth$ 1Q?.+?? ???	#FF004265.+??? $??EASYSAVE??$??Center=?$??Center=?$??Algerian)?$??Normal"?
???????$??38(??? $??1??.+??? -   $??10q????	#FF0056A7$??48????Z? .??? $	??150??$??30??.+?'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Shutdown=?$??Center=?$??-4,0,0,0q?
????????? -    ??Name$ StartCo??$??START CONNECTION??$??16,0,0,0q?$??
Sitka Text)? ?? TextAlignment$ Justify=?$??Center=?$
??Left=?$	??154??$??10(?
???????? $??1??$??1?? ?? $	??91* ??? $??* ?.+?? .+??? $??1??$??15q????	#FFD0D1D0 ?? RadiusX$ 11?? ?? RadiusY$ 11???? -    ??Name$ 	Save_work??$??27,65,363,27q??? -    ??Name$ ipserver??$??IP SERVER : ??$??
Sitka Text)?$??21,33,0,264q??? -    ??Name$ text_ipserevr??$??105,32,0,269q?$
??Left=?$	??188???? -   $ name_backup??$??Name:??$??
Sitka Text)?$??191,70,22,224q??? -   $ progression??$??Progressing : ??$??
Sitka Text)?$??190,98,148,204q??? -   ???	#FF004265$??314,129,154,156q???Z? .??? $??74??$??30??.+?  $ Pause=?$??Center=?
???????$??1,0,0,0q??? -	   $ 
PlauseText??$??PAUSE??$??21,0,0,0q?$??
Sitka Text)?$ Justify=?$??Center=?$
??Left=?$??54??$??10(?
????????? -
   ???	#FF004265$??416,129,52,156q???Z? .??? $??74??$??30??.+?  $
 Stop=?$??Center=?
???????$??1,0,0,0q??? -   $ StopText??$
??STOP??$??21,0,0,0q?$??
Sitka Text)?$ Justify=?$??Center=?$
??Left=?$??54??$??10(?
????????? -   $??283,233,114,45q????	#FF0056A7$??48????Z? .??? $	??150??$??30??.+?  $
 Show=?$??Center=?
???????$??1,0,0,0q??? -   $ LoadProgressText??$??PROGRESSING??$??21,0,0,0q?$??
Sitka Text)?$ Justify=?$??Center=?$
??Left=?$??84??$??10(?
????????? -   ???	#FF004265$??212,129,256,156q???Z? .??? $??74??$??30??.+?  $
 Play=?$??Center=?
???????$??1,0,0,0q??? -   $ 	PlayText1??$
??PLAY??$??21,0,0,0q?$??
Sitka Text)?$ Justify=?$??Center=?$
??Left=?$??54??$??10(?
???????? -    ?Name$ GridMenu??$??2?????	#FF0056A7.+???  ?? Orientation$ 
Horizontal=?$??Right=?.+??? -    ??Name$ 
Buttonexit??$??25??$??25??
?????????Z? ??Z? .??  $ Shutdown=?$??Center=?
???????