   M S B A M L   `   `   `  ����H  Dtelefonkönyv, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:telefonkönyvtelefonkönyv  5   	       telefonkönyv.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:telefonkönyv     5   	     � Title$  Telefonkönyv��5   	   $	��200��6   $	��800��6+   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��65* �6   �� 5      .+�5   
   �� ���	#FFF4F4F5$
��Left=�6%   $	��145��6@   $��	10,10,0,0q�6M   
���   �$	��Top=�6o   $	��284��6�   �� 5   
   $��Név: ��6   $
��Left=�6    $��	25,23,0,0q�6;   $	��Top=�6N   �� 5   
   $��Tel.: ��6   $
��Left=�6!   $��	25,66,0,0q�6<   $	��Top=�6O   �� 5   
   -   5        $��TextBoxName��5   �   $
��Left=�6   $��23��6-   $��	79,27,0,0q�69    �� TextWrapping$
 Wrap=�6L   $�� ��6`   $	��Top=�6h   $	��181��6�   6�   �� 5   
   -   5        $��TextBoxNumber��5   �   $
��Left=�6   $��23��6-   $��	79,69,0,0q�69   $
 Wrap=�6L   $�� ��6`   $	��Top=�6h   $	��181��6�   6�   �� 5   
   -   5        $	��Add��5   w   $��Hozzáadás��6   $
��Left=�6%   $	��Top=�6@   $��75��6X   $��
25,124,0,0q�6c   6�   �� 5   
   -   5        $
��Edit��5   x   $��Módosítás��6   $
��Left=�6%   $��115,124,0,0q�6@   $	��Top=�6U   $��75��6m   6�   �� 5   
   -   5        $��Delete��5   u   $��Törlés��6   $
��Left=�6"   $��209,124,0,0q�6=   $	��Top=�6R   $��75��6j   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��adatok��5   s   $
��Left=�6   $	��145��6.   $��
332,10,0,0q�6;   $	��Top=�6O   $	��450��6g      AutoGenerateColumns .  $��2��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Név��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 7* 6K   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Name+6K     5      $ Telefonszám��6%   $ 5* 6U    6:   �� *Number+6U   5      5      5      