   M S B A M L   `   `   `  ����H  DRife.Keyboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:Rife.Keyboard;assembly=Rife.KeyboardRife.Keyboard  5	       euroPlus4_1$   euroPlus4_1.Views.UsuariosView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f;controls,http://metro.mahapps.com/winfx/xaml/controls  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      ^ ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac	 _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af
 bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  	 
                    5      gkbrd2clr-namespace:Rife.Keyboard;assembly=Rife.Keyboard  	 
                    5	      -   5          N� Title$  UsuariosView��5      .��5      � $	��698��6   .+�5   
   �� $��Stretch=�6   $��Stretch=�63   $
��1146��6O   $	��698��6\   .+�5      �� $��45��6   $��Stretch=�6%   $
��1146��6D   $��0 0 0 0q�6Q    J� Opacity$	 0.8Q�6c   .+�5      �� $��10q�6   $��20(�6(    �� TextAlignment$ Center=�66   $��Center=�6M   
�������	Usuários6�   5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  5      $��0q�62   $	��653��6>   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffects 5      ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5         Kind$ FadeIn=�66      Duration$ 0:0:0.8h�6D   .��5      � $��10q�6   .+�5      4  .MahApps.Metro.Controls.MetroAnimatedTabControl  -  'MahApps.Metro.Controls.TabControlHelper   
Underlined$ TabPanel=�6M   ��67   Z� .@�5      )  #MahApps.Metro.Controls.MetroTabItem  $��
 corrente ��60   .��5      �� $	��584��6)   $��10q�66    �� Orientation$ 
Horizontal=�6B   .+�5   "   �� $	��900��6-   .+�5    &   �� $��5q�60   $��20(�6;   $��SemiBold"�6I   
�������Dados do usuário atual6�   �� 5!   &   $ 
Horizontal=�61   .+�5"   *   2  ,MahApps.Metro.IconPacks.PackIconFeatherIcons  $��Center=�6I   $��8q�6f      Kind$
 User=�6q   
�������$��25��6�   $��25��6�   �� 5#   *   $��5q�64   $��Center=�6?   
�������$��18(�6n   $��Medium"�6|   Credenciais6�   5$   '   �� 5&   &   $ 
Horizontal=�61   .+�5'   *   �� $	��230��65   .+�5(   .   �� $��5q�68   $��Light"�6C   $��18(�6V   
�������Nome:6~   �� 5)   .   $��5q�68   $��Light"�6C   $��18(�6V   
�������Nível de acesso:6�   �� 5*   .   $��5q�68   $��Light"�6C   $��18(�6V   
�������Possui RFID:6�   �� 5+   .   $��5q�68   $��Light"�6C   $��18(�6V   
�������Data e hora do login:6�   5,   +   �� 5-   *   .+�5.   .   �� -   5        	 ��Name$	 lblNome��5.   8   $��5q�6I   $��Medium"�6T   $��18(�6h   
�������6�   �� 5/   .   -   5        $	 lblNivel��5/   8   $��5q�6J   $��Medium"�6U   $��18(�6i   
�������6�   �� 50   .   -   5        $	 lblRFID��50   8   $��5q�6I   $��Medium"�6T   $��18(�6h   
�������Não6�   �� 51   .   -   5        $	 lblData��51   8   $��5q�6I   $��Medium"�6T   $��18(�6h   
�������
08/09/20206�   52   +   53   '   �� 55   &   $ 
Horizontal=�61   $��
-8 15 0 10q�6J   .+�56   *     $��Center=�6I   $��8q�6f   $ AlertCircle=�6q   
����p��$��23��6�   $��23��6�   $��Center=�6�   �� 57   *   $��0 0 0 0q�64   $	��320��6E   $
��Wrap=�6T   $
��Left=�6h   $��Light"�6�   $��14(�6�   
����p��$��Center=�6�   caOs dados apresentados só podem ser editados na presença de um login em nível de administrador.6:  58   '   5=   #   �� 5?   "   $	��206��6-   .+�5@   &   �� $��5q�61   $ 
Horizontal=�6<   $
��Left=�6U   .+�5A   *   '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 	UserBadge=�6B   $��20��6S   $��20��6_   
�������$��Center=�6}   �� 5B   *   $��5q�64   $��Medium"�6?   $��12(�6S   
�������$��Center=�6t   Credenciais6�   5C   '   �� 5D   &   $
 Left=�60   $��5q�6E   $��Light"�6P   $��11(�6c   
�������$
��Wrap=�6�   ��Para a máxima segurança dos usuários, os dados de login só poderão ser editados, criados ou apagados por um usuário em nível de administrador.6(  5G   #   5I      5J        5M      $�� controle de acesso ��60   .��5O        $ TabPanel=�6U   $��8(�6�    �� TabStripPlacement$	 Top=�6�   ��6?   Z� .@�5P   "     $�� adicionar ��68   $��8(�6c   ��6M   Z� .��5Q   &   �� $	��584��61   $��10q�6>   $ 
Horizontal=�6J   .+�5S   *   �� $	��900��65   .+�5U   .   �� $��5q�68   $��20(�6C   $��SemiBold"�6Q   
�������Configuração de usuários6�   �� 5V   0   $ 
Horizontal=�6;   .+�5W   /   4	  .MahApps.Metro.IconPacks.PackIconMaterialDesign	  $��Center=�6P   $��8q�6m    	  Kind$ 	PersonPin=�6x   
�������$��25��6�   $��25��6�   �� 5X   1   $��5q�6;   $��Center=�6F   
�������$��18(�6u   $��Medium"�6�   Dados para adicionar usuário6�   5Y   ,   �� 5Z   ,   $��2q�66   $��Light"�6A   $��16(�6T   
�������Nome6{   �� 5[   .   $��0 0 0 10q�6W   *
  $MahApps.Metro.Controls.TextBoxHelper 
  SelectAllOnFocus . $	��350��6�   $��40��6�    �� TextAlignment$
 Left=�6�   $��22(�6�   $��Medium"�6�   $
��Left=�6�   ��66   �� *UsuarioAdd.Nome+6  �� 5]   ,   $��2q�66   $��Light"�6A   $��16(�6T   
�������Senha6|   �� 5^   .   $��0 0 0 10q�6Y    . $	��350��6�   $��40��6�   $��22(�6�   $��Medium"�6�   $
��Left=�6�   ��66   �� *UsuarioAdd.Senha+6�   �� 5`   .   $��2q�68   $��Light"�6C   $��16(�6V   
�������Dica de senha6�   �� 5a   .   $��0 0 0 10q�6]    . $	��350��6�   $��40��6�   $��22(�6�   $��Medium"�6�   $
��Left=�6�   ��66   �� *UsuarioAdd.DicaSenha+6�   �� 5c   .   $��2q�68   $��Light"�6C   $��16(�6V   
�������Código RFID6�   �� 5d   .   $��0 0 0 10q�6X    . $	��350��6�   $��40��6�   $��22(�6�   $��Medium"�6�   $
��Left=�6�   ��66   �� *UsuarioAdd.RFID+6�   �� 5f   /   $��2q�69   $��Light"�6D   $��16(�6W   
�������Nível de acesso6�   *  $MahApps.Metro.Controls.NumericUpDown  5g   .   $��0 0 0 10q�6E    . $	��350��6�   $��40��6�      UpDownButtonsWidth$ 50Q�6�      TextAlignment$
 Left=�6�      Minimum$ 0Q�6�      Maximum$ 10Q�6�   $��22(�6	  $��Medium"�6  $
��Left=�6+     Value 6�   �� *UsuarioAdd.Nivel+6I  �� 5l   &   $ 
Horizontal=�61   $��0 10 0 0q�6J   $��Center=�6\   .+�5n   2   �� $	��0.1q�69   $
��auto��6O   $��16(�6^   $��Medium"�6l   $	��350��6�   $
��Left=�6�   $��0 0 0 0q�6�   $
 0.66Q�6�    ,  (MahApps.Styles.Button.MetroSquare.Accent#���   6�   
���������6  �� *AdicionarUsuario+��5o   .   �� 5p   2   $ 
Horizontal=�6=   $��0q�6V   .+�5q   6   ,  &MahApps.Metro.IconPacks.PackIconModern  $��Center=�6O   $��8q�6l      Kind$ UserAdd=�6w   
�������$��25��6�   $��25��6�   �� 5r   6   $��5q�6@   $��Center=�6K   Adicionar usuário6y   5s   3   5u   +   5v   '   5x   #   �� 5z   "   $	��206��6-   .+�5{   &   �� $��5q�61   $ 
Horizontal=�6<   $
��Left=�6U   .+�5|   *     $
 	UserAlert=�6B   $��20��6S   $��20��6_   
�������$��Center=�6}   �� 5}   .   $��5q�68   $��Medium"�6C   $��12(�6W   
�������$��Center=�6x   Configurar acesso6�   5~   '   �� 5   *   $
 Left=�64   $��5q�6I   $��Light"�6T   $��11(�6g   
�������$
��Wrap=�6�   ��O euroPlus permite o controle de acesso por meio de níveis, quanto maior o nível maior o acesso. As telas podem ser vinculadas à níveis individualmente para fornecer acesso ou não para um determinado usuário, o(s) usuário(s) de nível 10 terá(ão) acesso de administrador.6�  5�   #   5�   +   5�   #     5�   "   $�� gerenciar ��68   $��8(�6c   ��6M   Z� .��5�   &   �� $ 
Horizontal=�61   .+�5�   *   �� $	��900��65   .+�5�   .   �� $ 
Horizontal=�69   .+�5�   2     $��Center=�6K   $��8q�6h   $
 List=�6s   
�������$��25��6�   $��25��6�   �� 5�   2   $��5q�6<   $��Center=�6G   
�������$��18(�6v   $��Medium"�6�    Lista de usuários cadastrados6�   5�   /   &   System.Windows.Controls.DataGrid  5�   .   $��2q�67      CanUserResizeRows .     SelectionMode$ Single=�6�   $
��Left=�6�    ! MahApps.Styles.DataGrid.Azure#���  6�      AutoGenerateColumns .     CanUserAddRows .     CanUserDeleteRows .  $��5q�6  $��12(�6�  $	��400��6�  $	��670��6�  ��6f   �� *ListaDeUsuarios+ �� SelectedItem 6�   �� *UsuarioSelecionado+ �� Mode$ TwoWay=�   Columns 5�   2   0  *System.Windows.Controls.DataGridTextColumn  5�   6   ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6`      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6�   1  +System.Windows.Controls.DataGridBoundColumn    Binding  6I   �� *ID+6�     5�   6   $
 Nome��6b    . $	 230 6�     6I   �� *Nome+6�     5�   6   $ Nível��6c    . $ 60 6�     6I   �� *Nivel+6�     5�   6   $
 RFID��6b    . $	 200 6�     6I   �� *RFID+6�     5�   6   $ Data de criação��6i    . $	 200 6�     6I   �� *DataCriacao+6�   5�   /   �� 5�   .   $	��0.1q�6X   $
��auto��6n   $��16(�6}   $��Medium"�6�   $
��Left=�6�   $��	5 20 0 10q�6�   $	��670��6�   $
 0.66Q�6�   #���   6�   
���������65   �� *RemoverUsuario+��5�   2   �� 5�   6   $ 
Horizontal=�6A   $��0q�6Z   .+�5�   :   .  (MahApps.Metro.IconPacks.PackIconBoxIcons  $��Center=�6U   $��8q�6r   !   Kind$! 
SolidUserX=�6}   
�������$��25��6�   $��25��6�   �� 5�   :   $��5q�6D   $��Center=�6O   Remover usuário6{   5�   7   5�   /   5�   +   �� 5�   *   $	��206��65   .+�5�   .   �� $��5q�69   $ 
Horizontal=�6D   $
��Left=�6]   .+�5�   2     $
 
UserRemove=�6J   $��20��6\   $��20��6h   
�������$��Center=�6�   �� 5�   2   $��5q�6<   $��Medium"�6G   $��12(�6[   
�������$��Center=�6|   Política de gerenciamento6�   5�   /   �� 5�   .   $
 Left=�68   $��5q�6M   $��Light"�6X   $��11(�6k   
�������$
��Wrap=�6�   ��Devido às politicas de segurança do euroPlus, não será mais possível editar os dados de usuário como senha ou código RFID. Caso necessite fazer a alteração, a mesma deverá ser realizada a partir da criação de um novo usuário. Não se esqueça que o euroPlus não permite nomes duplicados então deve-se apagar o usuário antes de cria-lo novamente.6�  5�   +   5�   '   5�   #     5�   "   $�� ajustar níveis ��68   $��8(�6h   ��6R   Z� .��5�   &   �� $ 
Horizontal=�61   .+�5�   *   �� $	��900��65   .+�5�   .   �� $ 
Horizontal=�69   .+�5�   2     $��Center=�6K   $��8q�6h   $
 List=�6s   
�������$��25��6�   $��25��6�   �� 5�   2   $��5q�6<   $��Center=�6G   
�������$��18(�6v   $��Medium"�6�   Lista de telas disponíveis6�   5�   /     5�   .   $��2q�67    .  $ Single=�6�   $
��Left=�6�   #���  6    .   .   .  $��5q�6�  $��12(�6�  $	��400��6�  $	��670��6�  ��6f   �� *ListaDeTelas+$ TwoWay=� 6�   �� *TelaSelecionada+$ TwoWay=� 5�   2     5�   6   $ Descrição��6g    . $	 610 6�     6I   �� *	Descricao+6�     5�   6   $ Nível��6c   $ 60 6s     6I   �� *Nivel+6s   5�   /   �� 5�   .   $ 
Horizontal=�69   .+�5�   .   �� $	��0.1q�6^   $
��auto��6t   $��16(�6�   $��Medium"�6�   $
��Left=�6�   $��	5 20 0 10q�6�   $	��320��6�   $
 0.66Q�6�   #���   6�   
���������65   �� *AtualizarNiveisTelas+��5�   2   �� 5�   6   $ 
Horizontal=�6A   $��0q�6Z   .+�5�   :     $��Center=�6U   $��8q�6r   $! 	SolidSave=�6}   
�������$��25��6�   $��25��6�   �� 5�   :   $��5q�6D   $��Center=�6O   Salvar configuração6   5�   7   5�   /   �� 5�   2   $	��0.1q�6c   $
��auto��6y   $��16(�6�   $��Medium"�6�   $
��Left=�6�   $��
30 20 0 10q�6�   $	��320��6�   $
 0.66Q�6�   #���   6�   
���������69   �� *AtualizarListaDeTelas+��5�   2   �� 5�   6   $ 
Horizontal=�6A   $��0q�6Z   .+�5�   :     $��Center=�6U   $��8q�6r   $! RegularRefresh=�6}   
�������$��25��6�   $��25��6�   �� 5�   :   $��5q�6D   $��Center=�6O   Atualizar lista6{   5�   7   5�   /   5�   /   5�   +   �� 5�   *   $	��206��65   .+�5�   .   �� $��5q�69   $ 
Horizontal=�6D   $
��Left=�6]   .+�5�   2     $
 
UserRemove=�6J   $��20��6\   $��20��6h   
�������$��Center=�6�   �� 5�   2   $��5q�6<   $��Medium"�6G   $��12(�6[   
�������$��Center=�6|   Política de gerenciamento6�   5�   /   �� 5�   .   $
 Left=�68   $��5q�6M   $��Light"�6X   $��11(�6k   
�������$
��Wrap=�6�   ��Devido às politicas de segurança do euroPlus, não será mais possível editar os dados de usuário como senha ou código RFID. Caso necessite fazer a alteração, a mesma deverá ser realizada a partir da criação de um novo usuário. Não se esqueça que o euroPlus não permite nomes duplicados então deve-se apagar o usuário antes de cria-lo novamente.6�  5�   +   5�   '   5�   #   5�      5�      5�      5�      5�      5�      +  %MahApps.Metro.Controls.FlyoutsControl  5�   
   $
��1146��6#   .@�5�      #  MahApps.Metro.Controls.Flyout   & "MahApps.Brushes.Control.Background#���  6   "   Position$	" Top=�6`   #   IsAutoCloseEnabled# . $   AutoCloseInterval$
$ 3000��6�   $��45��6�   %   CloseButtonVisibility$% 	Collapsed=�6�   &   IsOpen& 6�   �� *MostrarMensagem+.��5�      �� $ 
Horizontal=�6   $��Center=�66   $��Center=�6Q   #���  6n   .+�5�        $��Center=�65   $��0 0 10 0q�6R   $ CheckCircle=�6d     MahApps.Brushes.Accent#���  6w   $��20��6�   $��20��6�   �� 5�      $��16(�6    $��Center=�6.   ��6I   �� *ConteudoMensagem+6m   5�      5�      5�      5�      5�      