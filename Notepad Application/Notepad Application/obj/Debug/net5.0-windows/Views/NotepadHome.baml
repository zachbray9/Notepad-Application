   M S B A M L   `   `   `  ????N  JNotepad Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Notepad_Application.ViewsNotepad_Application.Views  5      +    %Notepad_Application.Views.NotepadHome   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:Notepad_Application.Views     5      .??5	      ?   ? RowDefinitions  5
   
   ?? 5      $
??Auto ?6   ?? 5      $??* ?6   .+?5   
   o? $??0??6   $??14(?6   $??Calibri)?6*   $??10, 10, 10, 0q?6?   .@?5      m? $
??File??6   $??10, 5, 10, 5q?6%   .@?5      m? -   5        $??newMenuItem??5      $	??New??6/    m? Command 6<   ?? *
NewCommand+m? 5      -   5        $??newWindowMenuItem??5      $??
New Window??64    6H   ?? *NewWindowCommand+m? 5      -   5        $??openMenuItem??5      $
??Open??6/    6>   ?? *OpenCommand+m? 5      -   5        $??saveMenuItem??5      $
??Save??6/    6=   ?? *SaveCommand+m? 5      -   5        $??saveAsMenuItem??5      $??Save As??61    6B   ?? *SaveAsCommand+?? 5      m? 5      -   5        $??pageSetupMenuItem??5      $??
Page Setup??64   $&  ApplicationCommands.PrintPreview??6H   m? 5      -   5        $??printMenuItem??5      $??Print??60   $ ApplicationCommands.Print??6?   ?? 5      m? 5      -   5        $??exitMenuItem??5      $
??Exit??6/    6=   ?? *ExitCommand+5      m? 5      $
??Edit??6   $??10, 5, 10, 5q?6%   .@?5      m? $
??Undo??6   $ ApplicationCommands.Undo??6)   ?? 5      m? 5      -	   5        $??cutMenuItem??5      $	??Cut??6.   $ ApplicationCommands.Cut??6;   m? 5       $
??Copy??6   $ ApplicationCommands.Copy??6)   m? 5!      $??Paste??6   $ ApplicationCommands.Paste??6*   m? 5"      $??Delete??6   $  ApplicationCommands.Delete??6+   ?? 5#      m? 5$      $
??Find??6   $ ApplicationCommands.Find??6)   m? 5%      $??Replace??6   $! ApplicationCommands.Replace??6,   ?? 5&      m? 5'      $??
Select All??6   $# ApplicationCommands.SelectAll??6/   5(      m? 5)      $
??View??6   $??10, 5, 10, 5q?6-   .@?5*      m? -
   5        $??darkModeMenuItem??5*      $??	Dark Mode??63    m? IsCheckable$
 True??6F   5+      5,      ?? 5-   
   -   5        $??documentTextbox??5-      $??1??6)   $
??Auto??67   $??0, 10q?6E    ?? AcceptsReturn$
 True??6U    ?? 
AcceptsTab$
 True??6j    ?? TextWrapping$ NoWrap=?6|   $
??True??6?   " ?? VerticalScrollBarVisibility$
 Auto=?6?   $ ?? HorizontalScrollBarVisibility$
 Auto=?6?    ?? IsUndoEnabled$
 True??6:  ??6?   ?? *Text+	 ?? UpdateSourceTrigger$	 PropertyChanged=?6:  5.      5/      