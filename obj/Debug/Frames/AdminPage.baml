   M S B A M L   `   `   `  ????J  FAirlines amonic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Airlines_amonic.FramesAirlines_amonic.Frames  5      &     Airlines_amonic.Frames.AdminPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:Airlines_amonic.Frames     5        N? Title$  	AdminPage??5	      $	??350??6   $	??480??6&   .??5      ? ???#FFFACB.+?5   
   &   System.Windows.Controls.DataGrid  -   5        $??MetricsDataGrid??5      $??3,85,7,48.4q?6*      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   ?? *	FirstName+  5      $ LastName??6%    67   ?? *
LastName+  5      $	 Age??6%    62   ?? *age+  5      $ 	User Role??6%    68   ?? *Role+  5      $ Email Addres??6%    6;   ?? *Email+  5      $ Office??6%    65   ?? *Office+5      o? 5   
   ???#F79420$
??Left=?6%   $??35??6@   $??0,2,0,0q?6L   $	??Top=?6]   $	??475??6u   .@?5      ?? -   5        $??Add User??5      ???#196AA6
??????????#196AA6$
??Left=?6g   $??Center=?6?   $??85??6?   $??25??6?   6?   ?? 5      -   5        $
??Exit??5      ???#196AA6
??????????#196AA6$
??Left=?6d   $??Center=?6   $??85??6?   $??25??6?   6?   5      ?? 5   
   $??Office:??6   $
??Left=?6"   $??	28,50,0,0q?6=   $	??Top=?6P   ?? 5   
   -   5         ??Name$ officeCB??5      $
??Left=?6%   $??	72,52,0,0q?6@   $	??Top=?6S   $	??120??6k   .@?5       ?? .??6   	Abu Dhabi6&   ?? 5!      .??6   Cairo6"   ?? 5"      .??6   	Bahrain6$   ?? 5#      .??6   Doha6!   ?? 5$      .??6   Riyadh6#   5%      ?? 5&   
   -   5        $??Change Role??5&      
??????????#196AA6$
??Left=?6P   $??
23,321,0,0q?6k   $	??Top=?6   $??75??6?   6?   ?? 5'   
   -   5        $??Enable/Disable Login??5'      
??????????#196AA6$
??Left=?6Y   $??147,321,0,0q?6t   $	??Top=?6?   $	??128??6?   6?   5)      5*      