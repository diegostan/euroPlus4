   M S B A M L   `   `   `  ����H  DRife.Keyboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:Rife.Keyboard;assembly=Rife.KeyboardRife.Keyboard  5	       euroPlus4_1"   euroPlus4_1.Views.AlarmeView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f;controls,http://metro.mahapps.com/winfx/xaml/controls  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      ^ ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac	 _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af
 bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  	 
                    5      gkbrd2clr-namespace:Rife.Keyboard;assembly=Rife.Keyboard  	 
                    5	        N� Title$  
AlarmeView��5      .��5      � $	��698��6   .+�5   
   �� $��Stretch=�6   $��Stretch=�63   $
��1146��6O   $	��698��6\   .+�5      �� $��45��6   $��Stretch=�6%   $
��1146��6D   $��0 0 0 0q�6Q    J� Opacity$	 0.8Q�6c   .+�5      �� $��10q�6   $��20(�6(    �� TextAlignment$ Center=�66   $��Center=�6M   
�������	Alarmes6�   5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  5      $��0q�62   $	��653��6>   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffects 5      ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5         Kind$ FadeIn=�66      Duration$ 0:0:0.8h�6D   .��5      � $��10q�6   .+�5      4  .MahApps.Metro.Controls.MetroAnimatedTabControl  -  'MahApps.Metro.Controls.TabControlHelper   
Underlined$ TabPanel=�6M   ��67   Z� .@�5      )  #MahApps.Metro.Controls.MetroTabItem  $�� ativos ��60   .��5      �� $	��584��6)   $��10q�66    �� Orientation$ 
Horizontal=�6B   .+�5   "   �� $	��900��6-   .+�5   &   �� $��5q�60   $��20(�6;   $��SemiBold"�6I   
�������	Alarmes6{   �� 5    &   $ 
Horizontal=�61   $��0 0 0 10q�6J   .+�5!   *   .  (MahApps.Metro.IconPacks.PackIconMaterial  $��Center=�6E   $��8q�6b      Kind$ AlertBox=�6m   
�������$��25��6�   $��25��6�   �� 5"   *   $��5q�64   $��Center=�6?   
�������$��18(�6n   $��Medium"�6|   Visualização de listagem6�   5#   '   &   System.Windows.Controls.DataGrid  5%   &   $
��Left=�6\    !  MahApps.Styles.DataGrid.Azure#���   6w   	   AutoGenerateColumns	 .  
   CanUserAddRows
 .     CanUserDeleteRows .  $��5q�6�   $��12(�6  $	��400��6  $	��560��6$  ��6/   �� *ListaDeAlarmesAtivos+   Columns 5&   *   0	  *System.Windows.Controls.DataGridTextColumn	  5(   .   ,
  &System.Windows.Controls.DataGridColumn 
  Header$ Código��6B    
  
IsReadOnly .  
  Width5  /System.Windows.Controls.DataGridLengthConverter$ 70 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6S   �� *Codigo+6�   	  5)   .   $ Data e hora��6B    . $	 150 6�    6W   �� *
DataHora+6�   	  5*   .   $ Mensagem��6B    . $
 auto 6�    6T   �� *
Mensagem+6�   5-   '   �� 51   &   $ 
Horizontal=�61   $��0 20 0 0q�6J   $��Center=�6\   .+�53   *   �� $	��0.1q�61   $
��auto��6G   $��16(�6V   $��Medium"�6d   $	��565��6x   $
��Left=�6�   $��0 0 0 0q�6�   $
 0.66Q�6�    , (MahApps.Styles.Button.MetroSquare.Accent#���  6�   
���������6  �� *LimpaListaAlarmes+��54   .   �� 55   2   $ 
Horizontal=�6=   $��0q�6V   .+�56   6     $��Center=�6Q   $��8q�6n   $ CheckAll=�6y   
�������$��25��6�   $��25��6�   �� 57   6   $��5q�6@   $��Center=�6K   Verificar alarmes6y   58   3   5:   +   5;   '   5=   #   �� 5?   "   $	��206��6-   .+�5@   &   �� $��5q�61   $ 
Horizontal=�6<   $
��Left=�6U   .+�5A   *   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Alert=�6B   $��20��6O   $��20��6[   
�������$��Center=�6y   �� 5B   *   $��5q�64   $��Medium"�6?   $��12(�6S   
�������$��Center=�6t   	Alarmes6�   5C   '   �� 5D   &   $
 Left=�60   $��5q�6E   $��Light"�6P   $��11(�6c   
�������$
��Wrap=�6�   ��A listagem de alarme apresenta os alertas gerados por falhas em tolerâncias ou modos incorretos de operação, cada alarme ao ser apresentado possui um código de erro e a data/hora do fato ocorrido.6^  �� 5F   &   $��	5 20 0 0 q�61   $ 
Horizontal=�6D   $
��Left=�6]   .+�5G   *     $ Check=�6B   $��20��6O   $��20��6[   
�������$��Center=�6y   �� 5H   *   $��5q�64   $��Medium"�6?   $��12(�6S   
�������$��Center=�6t   Verificação6�   5I   '   �� 5J   &   $
 Left=�60   $��5q�6E   $��Light"�6P   $��11(�6c   
�������$
��Wrap=�6�   ��Os alarmes gerados são persistentes para manter um histórico de ocorrencia na não presença de um operador, para apagá-los basta tocar no botão de Verificar alarmes.6>  5L   #   5N      5O        5P      $�� configurações ��60   {�.  5R      5W      5X      5Z      5\      +  %MahApps.Metro.Controls.FlyoutsControl  5]   
   $
��1146��6#   .@�5^      #  MahApps.Metro.Controls.Flyout     Position$	 Top=�6      IsAutoCloseEnabled .    AutoCloseInterval$
 3000��6G   $��45��6`      CloseButtonVisibility$ 	Collapsed=�6�      IsOpen 6m   �� *MostrarMensagem+.��5_      �� $ 
Horizontal=�6   $��Center=�66   $��Center=�6Q   .+�5`      2  ,MahApps.Metro.IconPacks.PackIconFeatherIcons  $��Center=�65   $��0 0 10 0q�6R      Kind$ CheckCircle=�6d     MahApps.Brushes.Accent#���  6w   $��20��6�   $��20��6�   �� 5a      $��16(�6    $��Center=�6.   ��6I   �� *ConteudoMensagem+6m   5b      5d      5e      5h      5i      