   M S B A M L   `   `   `  ����H  DRife.Keyboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:Rife.Keyboard;assembly=Rife.KeyboardRife.Keyboard  5	       euroPlus4_1-   'euroPlus4_1.Views.TemposFrequenciasView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f;controls,http://metro.mahapps.com/winfx/xaml/controls  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      ^ ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac	 _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af
 bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  	 
                    5      gkbrd2clr-namespace:Rife.Keyboard;assembly=Rife.Keyboard  	 
                    5	        N� Title$  TemposFrequenciasView��5      .��5      � $	��698��6   .+�5   
   �� $��Stretch=�6   $��Stretch=�63   $
��1146��6O   $	��698��6\   .+�5      �� $��45��6   $��Stretch=�6%   $
��1146��6D   $��0 0 0 0q�6Q    J� Opacity$	 0.8Q�6c   .+�5      �� $��10q�6   $��20(�6(    �� TextAlignment$ Center=�66   $��Center=�6M   
�������Tempos e frequências6�   5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  5      $��0q�62   $	��653��6>   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffects 5      ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5         Kind$ FadeIn=�66      Duration$ 0:0:0.8h�6D   .��5      � $��10q�6   .+�5      4  .MahApps.Metro.Controls.MetroAnimatedTabControl  -   5          Name$
 menu��5   M   -  'MahApps.Metro.Controls.TabControlHelper   
Underlined$ TabPanel=�6[   ��67   Z� .@�5      )  #MahApps.Metro.Controls.MetroTabItem  $��	 ajustes ��60   .��5      �� $	��584��6)   $��10q�66    �� Orientation$ 
Horizontal=�6B   .+�5   "   �� $	��900��6-   .+�5   &   �� $��5q�60   $��20(�6;   $��SemiBold"�6I   
�������Controle de frequência6�   �� 5    &   $ 
Horizontal=�61   .+�5!   *   1  +MahApps.Metro.IconPacks.PackIconFontAwesome  $��Center=�6H   $��8q�6e   	   Kind$	 WaveSquareSolid=�6p   
�������$��25��6�   $��25��6�   �� 5"   *   $��5q�64   $��Center=�6?   
�������$��18(�6n   $��Medium"�6|   +)Definir frequência de pulsação (Hertz)6�   5#   '   �� 5$   &   $	��350��6-   $��50��69   $
��Left=�6E   
 � Maximum$
 5Q�6`    � Minimum$ 0Q�6l   $��	0 10 0 10q�6x    �� TickPlacement$ TopLeft=�6�    �� TickFrequency$	 0.1Q�6�    � Value$ 0Q�6�   6�   *  $MahApps.Metro.Controls.NumericUpDown  5&   &   -   5        $��0 0 0 10q�5&   =   *	  $MahApps.Metro.Controls.TextBoxHelper 	  SelectAllOnFocus . $	��350��6�   $��50��6�      UpDownButtonsWidth$ 50Q�6�      TextAlignment$
 Left=�6�      Minimum$ 0Q�6�      Maximum$ 5Q�6�      Interval$	 0.1Q�6�   $��26(�6�   $��Medium"�6�   $
��Left=�6     Value 6*  �� *TemposFrequencias.Frequencia+6�  �� 5)   &   $ 
Horizontal=�61   .+�5*   *   .
  (MahApps.Metro.IconPacks.PackIconMaterial
  $��Center=�6E   $��8q�6b    
  Kind$ 	Autorenew=�6m   
�������$��25��6�   $��25��6�   �� 5+   *   $��5q�64   $��Center=�6?   
�������$��18(�6n   $��Medium"�6|   " Tempo de circulação (segundos)6�   5,   '     5-   &   -   5        $��0 0 0 10q�5-   =    . $	��350��6�   $��50��6�   $ 50Q�6�   $
 Left=�6�   $ 0Q�6�   $	 100Q�6�   $��26(�6�   $��Medium"�6�   $
��Left=�6   6  �� *%#TemposFrequencias.TempoDeCirculacao+6�  �� 5/   &   $ 
Horizontal=�61   $��	-8 5 0 10q�6J   .+�50   *   2  ,MahApps.Metro.IconPacks.PackIconFeatherIcons  $��Center=�6I   $��8q�6f      Kind$ AlertCircle=�6q   
�������$��23��6�   $��23��6�   $��Center=�6�   �� 51   *   $��0 0 0 0q�64   $	��320��6E   $
��Wrap=�6T   $
��Left=�6h   $��Light"�6�   $��14(�6�   
�������$��Center=�6�   ��Os valores de controle de frequência de pulsação bem como o tempo de circulação, só poderão ser aplicados em modo manual de operação.6X  52   '   �� 55   &   $ 
Horizontal=�61   $��0 20 0 0q�6J   $��Center=�6\   .+�57   *   �� $	��0.1q�61   $
��auto��6G   $��16(�6V   $��Medium"�6d   $	��350��6x   $
��Left=�6�   $��0 0 0 0q�6�   $
 0.66Q�6�    ,  (MahApps.Styles.Button.MetroSquare.Accent#���   6�   
���������6  �� *EnviarAjsutesFrequencia+��58   .   �� 59   2   $ 
Horizontal=�6=   $��0q�6V   .+�5:   6   ,  &MahApps.Metro.IconPacks.PackIconModern  $��Center=�6O   $��8q�6l      Kind$ CheckmarkPencil=�6w   
�������$��25��6�   $��25��6�   �� 5;   6   $��5q�6@   $��Center=�6K   Aplicar valores6w   5<   3   5>   +   5?   '   5A   #   �� 5C   "   $	��206��6-   .+�5D   &   �� $��5q�61   $ 
Horizontal=�6<   $
��Left=�6U   .+�5E   *   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Wave=�6B   $��20��6N   $��20��6Z   
�������$��Center=�6x   �� 5F   *   $��5q�64   $��Medium"�6?   $��12(�6S   
�������$��Center=�6t   Controle de frequência6�   5G   '   �� 5H   &   $
 Left=�60   $��5q�6E   $��Light"�6P   $��11(�6c   
�������$
��Wrap=�6�   JHDefine a frequeência com que o sistema ira pulsar a válvula de alivio.6�   �� 5J   &   $��	5 20 0 0 q�61   $ 
Horizontal=�6D   $
��Left=�6]   .+�5K   *   0  *MahApps.Metro.IconPacks.PackIconRPGAwesome  $��Center=�6G      Kind$ Cycle=�6d   
�������$��20��6�   $��20��6�   �� 5L   *   $��5q�64   $��Medium"�6?   $��12(�6S   
�������$��Center=�6t   Tempo de circulação6�   5M   '   �� 5N   &   $
 Left=�60   $��5q�6E   $��Light"�6P   $��11(�6c   
�������$
��Wrap=�6�   ��Após iniciar o ciclo do teste de repetição, esse tempo é utilizado para circular o fluido no sistema hidráulico, após o término desse tempo o teste é iniciado com a frequência definida.6S  5P   #   5R      5S        5T      $�� configurações ��60   {�.  .��5U      �� $	��584��6)   $��10q�66   $ 
Horizontal=�6B   .+�5V   "   �� $	��900��6-   .+�5W   &   �� $��5q�60   $��20(�6;   $��SemiBold"�6I   
�������Configuração de extremos6�   �� 5X   &   $ 
Horizontal=�61   .+�5Y   *     $��Center=�6C   $��8q�6`   $ GraphLineUp=�6k   
�������$��25��6�   $��25��6�   �� 5Z   *   $��5q�64   $��Center=�6?   
�������$��18(�6n   $��Medium"�6|   Valores máximos6�   5[   '   �� 5\   &   $��5q�60   $��Light"�6;   $��16(�6N   
�������!Vazão máxima da bomba (L/Min)6�     5]   &   -   5        $��0 0 0 10q�5]   =    . $	��350��6�   $��50��6�   $ 50Q�6�   $
 Left=�6�   $ 0Q�6�   $	 100Q�6�   $ 0X�6�   $��26(�6�   $��Medium"�6�   $
��Left=�6  6n  �� 5_   &   $��5q�60   $��Light"�6;   $��16(�6N   
�������&$Frequência máxima da bomba (Hertz)6�     5`   &   -   5        $��0 0 0 10q�5`   =    . $	��350��6�   $��50��6�   $ 50Q�6�   $
 Left=�6�   $ 0Q�6�   $	 400Q�6�   $ 0X�6�   $��26(�6�   $��Medium"�6�   $
��Left=�6  6n  �� 5b   &   $��5q�60   $��Light"�6;   $��16(�6N   
�������,*Corrente de controle máxima da bomba (mA)6�     5c   &   -   5        $��0 0 0 10q�5c   =    . $	��350��6�   $��50��6�   $ 50Q�6�   $
 Left=�6�   $ 4Q�6�   $ 20Q�6�   $ 4X�6�   $��26(�6�   $��Medium"�6�   $
��Left=�6
  6m  �� 5e   &   $ 
Horizontal=�61   .+�5f   *     $��Center=�6C   $��8q�6`   $ GraphLineDown=�6k   
�������$��25��6�   $��25��6�   �� 5g   *   $��5q�64   $��Center=�6?   
�������$��18(�6n   $��Medium"�6|   Valores mínimos6�   5h   '   �� 5i   &   $��5q�60   $��Light"�6;   $��16(�6N   
�������,*Corrente de controle mínima da bomba (mA)6�     5j   &   -   5        $��0 0 0 10q�5j   =    . $	��350��6�   $��50��6�   $ 50Q�6�   $
 Left=�6�   $ 4Q�6�   $ 15Q�6�   $ 4X�6�   $��26(�6�   $��Medium"�6�   $
��Left=�6
  6m  �� 5p   &   $ 
Horizontal=�61   $��0 20 0 0q�6J   $��Center=�6\   .+�5r   *   �� $	��0.1q�61   $
��auto��6G   $��16(�6V   $��Medium"�6d   $	��350��6x   $
��Left=�6�   $��0 0 0 0q�6�   $
 0.66Q�6�   #���   6�   
���������5s   .   �� 5t   2   $ 
Horizontal=�6=   $��0q�6V   .+�5u   6     $��Center=�6O   $��8q�6l   $ CheckmarkPencil=�6w   
�������$��25��6�   $��25��6�   �� 5v   6   $��5q�6@   $��Center=�6K   Aplicar valores6w   5w   3   5y   +   5z   '   5|   #   �� 5~   "   $	��206��6-   .+�5   &   �� $��5q�61   $ 
Horizontal=�6<   $
��Left=�6U   .+�5�   *     $ UploadMultiple=�6B   $��20��6X   $��20��6d   
�������$��Center=�6�   �� 5�   *   $��5q�64   $��Medium"�6?   $��12(�6S   
�������$��Center=�6t   Configurar extremos6�   5�   '   �� 5�   &   $
 Left=�60   $��5q�6E   $��Light"�6P   $��11(�6c   
�������$
��Wrap=�6�   ��Forneceça as informações de valores máximos e mínimos do equipamento bem como o controle da saída analógica do controlador.6  5�   #   5�      5�      5�      5�      5�      5�      +  %MahApps.Metro.Controls.FlyoutsControl  5�   
   $
��1146��6#   .@�5�      #  MahApps.Metro.Controls.Flyout     Position$	 Top=�6      IsAutoCloseEnabled .    AutoCloseInterval$
 3000��6G   $��45��6`      CloseButtonVisibility$ 	Collapsed=�6�      IsOpen 6m   �� *MostrarMensagem+.��5�      �� $ 
Horizontal=�6   $��Center=�66   $��Center=�6Q   .+�5�        $��Center=�65   $��0 0 10 0q�6R   $ CheckCircle=�6d     MahApps.Brushes.Accent#���  6w   $��20��6�   $��20��6�   �� 5�      $��16(�6    $��Center=�6.   ��6I   �� *ConteudoMensagem+6m   5�      5�      5�      5�      5�      