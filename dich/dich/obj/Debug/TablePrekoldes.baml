   M S B A M L   `   `   `  ?????  ;dich, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:dichdich  5   	       dich.TablePrekoldes   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:dich     5   	     ? Title$  TablePrekoldes??5   	   $	??450??6    $	??800??6-   .??5	      ? .+?5
   
   ?? -   5         ??Name$ btnEdit??5
      $??Изменить??6"   $
??Left=?65   $??
643,43,0,0q?6P   $	??Top=?6d   $??75??6|   $??24??6?    ? ContextMenu 5      ?? 5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
phonesGrid??5      $
??Left=?6'   $	??229??6B   $??	25,43,0,0q?6O   $	??Top=?6b   $	??575??6z      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Серия??6?      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ?? *
Серия+6N     5      $ 
Номер??6?   $	 125 6N    6%   ?? *
Номер+6N     5      $ Дата рождения??6F   $	 125 6]    6%   ?? *ДатаРождения+6]     5      $&  Дата начала стажа??6I   $	 140 6d    6%   ?? * ДатаНачалаСтажа+6d   5      ?? 5   
   -   5        $ 	btnInsert??5      $??Добавить??6$   $
??Left=?67   $??
643,93,0,0q?6R   $	??Top=?6f   $??77??6~   $??29??6?   6?   ?? 5   
   -   5        $ 	btnDelete??5      $??Удалить??6$   $
??Left=?66   $??647,143,0,0q?6Q   $	??Top=?6f   $??75??6~   $??26??6?   6?   5      5      