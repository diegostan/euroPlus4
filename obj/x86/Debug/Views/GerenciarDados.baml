   M S B A M L   `   `   `  ����H  DRife.Keyboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:Rife.Keyboard;assembly=Rife.KeyboardRife.Keyboard  5	       euroPlus4_1&    euroPlus4_1.Views.GerenciarDados   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f;controls,http://metro.mahapps.com/winfx/xaml/controls  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      ^ ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac	 _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af
 bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  	 
                    5      gkbrd2clr-namespace:Rife.Keyboard;assembly=Rife.Keyboard  	 
                    5	        N� Title$  GerenciarDados��5      .��5      � $	��698��6   .+�5   
   �� $��Stretch=�6   $��Stretch=�63   $
��1146��6O   $	��698��6\   .+�5      �� $��45��6   $��Stretch=�6%   $
��1146��6D   $��0 0 0 0q�6Q    J� Opacity$	 0.8Q�6c   .+�5      �� $��10q�6   $��20(�6(    �� TextAlignment$ Center=�66   $��Center=�6M   
�������Gerenciar dados6�   5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  5      $��0q�62   $	��653��6>   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffects 5      ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5         Kind$ FadeIn=�66      Duration$ 0:0:0.8h�6D   .��5      � $��10q�6   .+�5      4  .MahApps.Metro.Controls.MetroAnimatedTabControl  -  'MahApps.Metro.Controls.TabControlHelper   
Underlined$ TabPanel=�6M   ��67   Z� .@�5      )  #MahApps.Metro.Controls.MetroTabItem  $�� salvar ��60   .��5      �� $	��584��6)   $��10q�66    �� Orientation$ 
Horizontal=�6B   .+�5   "   �� $	��900��6-   .+�5   &   �� $��5q�60   $��20(�6;   $��SemiBold"�6I   
�������Salvar parâmetros6�   �� 5!   &   $ 
Horizontal=�61   .+�5"   *   .  (MahApps.Metro.IconPacks.PackIconMaterial  $��Center=�6E   $��8q�6b      Kind$ FileCad=�6m   
�������$��25��6�   $��25��6�   �� 5#   *   $��5q�64   $��Center=�6?   
�������$��18(�6n   $��Medium"�6|    Nome do arquivo de parâmetros6�   5$   '   �� 5%   &   $��0 0 0 10q�6.   *  $MahApps.Metro.Controls.TextBoxHelper	   SelectAllOnFocus	 . $	��350��6q   $��50��6}   
 �� TextAlignment$

 Left=�6�   $��26(�6�   $��Medium"�6�   $
��Left=�6�   ��6�   �� *GerenciarDados.NomeArquivo+6
  �� 5'   &   $ 
Horizontal=�61   $��	-8 5 0 10q�6J   .+�5(   *   2	  ,MahApps.Metro.IconPacks.PackIconFeatherIcons	  $��Center=�6I   $��8q�6f    	  Kind$ AlertCircle=�6q   
�������$��23��6�   $��23��6�   $��Center=�6�   �� 5)   *   $��0 0 0 0q�64   $	��320��6E   $
��Wrap=�6T   $
��Left=�6h   $��Light"�6�   $��14(�6�   
�������$��Center=�6�   ��Cada arquivo deve possuir um nome único na base de dados, ao salvar um novo, os dados de usuário atual e data/hora atual são salvos junto ao arquivo de parametros.6v  5*   '   �� 5-   &   $ 
Horizontal=�61   $��0 20 0 0q�6J   $��Center=�6\   .+�5/   *   �� $	��0.1q�61   $
��auto��6G   $��16(�6V   $��Medium"�6d   $	��350��6x   $
��Left=�6�   $��0 0 0 0q�6�   $
 0.66Q�6�    ,  (MahApps.Styles.Button.MetroSquare.Accent#���   6�   
���������6  �� *SalvarDados+��50   .   �� 51   2   $ 
Horizontal=�6=   $��0q�6V   .+�52   6   ,
  &MahApps.Metro.IconPacks.PackIconModern
  $��Center=�6O   $��8q�6l    
  Kind$ 
DiskUpload=�6w   
�������$��25��6�   $��25��6�   �� 53   6   $��5q�6@   $��Center=�6K   Salvar dados6t   54   3   56   +   57   '   59   #   �� 5;   "   $	��206��6-   .+�5<   &   �� $��5q�61   $ 
Horizontal=�6<   $
��Left=�6U   .+�5=   *   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ DatabaseImport=�6B   $��20��6X   $��20��6d   
�������$��Center=�6�   �� 5>   *   $��5q�64   $��Medium"�6?   $��12(�6S   
�������$��Center=�6t   Armazenamento de dados6�   5?   '   �� 5@   &   $
 Left=�60   $��5q�6E   $��Light"�6P   $��11(�6c   
�������$
��Wrap=�6�   ��Para salvar os parâmetros do sistema, certifique-se de que há uma base de dados instalada e configurada. o euroPlus permite que os dados salvos na estrutura de dados sejam limitadas pelo tamanho máximo da base, não existe limite para o armazenamento dentro do euroPlus.6�  5D   #   5F      5G        5H      $�� gerenciar ��60   {�. .��5I      �� $	��584��6)   $��10q�66   $ 
Horizontal=�6B   .+�5J   "   �� $	��900��6-   .+�5K   &   �� $��5q�60   $��20(�6;   $��SemiBold"�6I   
�������Carregar parâmetros6�   �� 5M   &   $ 
Horizontal=�61   .+�5N   *     $��Center=�6E   $��8q�6b   $ ClipboardList=�6m   
�������$��25��6�   $��25��6�   �� 5O   *   $��5q�64   $��Center=�6?   
�������$��18(�6n   $��Medium"�6|   Lista de arquivos armazenados6�   5P   '   &   System.Windows.Controls.DataGrid  5R   &   $��2q�6/      CanUserResizeRows .     SelectionMode$ Single=�6�   $
��Left=�6�    ! MahApps.Styles.DataGrid.Azure#���  6�      AutoGenerateColumns .     CanUserAddRows .     CanUserDeleteRows .  $��5q�6t  $��12(�6  $	��400��6�  $	��670��6�  ��6^   �� *ListaDeDados+ �� SelectedItem 6�   �� *ArquivoSelecionado+ �� Mode$ TwoWay=�   Columns 5S   *   0  *System.Windows.Controls.DataGridTextColumn  5T   .   ,  &System.Windows.Controls.DataGridColumn   Header$ Nome arquivo��6a      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 250 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *NomeArquivo+6�     5U   .   $ Data de criação��6a    . $	 220 6�    6A   �� *DataCriacao+6�     5V   .   $ 
Criado por��6d    . $	 200 6�    6A   �� *UsuarioCriador+6�   5X   '   �� 5Z   (   $ 
Horizontal=�63   $��0 20 0 0q�6L   $��Center=�6^   .+�5\   *   �� $	��0.1q�61   $
��auto��6G   $��16(�6V   $��Medium"�6d   $	��320��6x   $
��Left=�6�   $��5 0 0 0q�6�   $
 0.66Q�6�   #���   6�   
���������6  �� *CarregarDados+��5]   .   �� 5^   2   $ 
Horizontal=�6=   $��0q�6V   .+�5_   6   
  $��Center=�6O   $��8q�6l   $ DiskDownload=�6w   
�������$��25��6�   $��25��6�   �� 5`   6   $��5q�6@   $��Center=�6K   Carregar arquivo selecionado6�   5a   3   5c   +   �� 5e   *   $	��0.1q�61   $
��auto��6G   $��16(�6V   $��Medium"�6d   $	��320��6x   $
��Left=�6�   $��30 0 0 0q�6�   $
 0.66Q�6�   #���   6�   
���������6  �� *ExcluirDados+��5f   .   �� 5g   2   $ 
Horizontal=�6=   $��0q�6V   .+�5h   6   
  $��Center=�6O   $��8q�6l   $ ClearInverse=�6w   
�������$��25��6�   $��25��6�   �� 5i   6   $��5q�6@   $��Center=�6K   Remover arquivo selecionado6�   5j   3   5l   +   5m   '   5o   #   �� 5q   "   $	��206��6-   .+�5r   &   �� $��5q�61   $ 
Horizontal=�6<   $
��Left=�6U   .+�5s   *     $ DatabaseExport=�6B   $��20��6X   $��20��6d   
�������$��Center=�6�   �� 5t   *   $��5q�64   $��Medium"�6?   $��12(�6S   
�������$��Center=�6t   Carregar arquivos6�   5u   '   �� 5v   &   $
 Left=�60   $��5q�6E   $��Light"�6P   $��11(�6c   
�������$
��Wrap=�6�   ��O sistema só permitirá o carregamento de dados em caso de comunicação estabelecida com o controlador, ao carregar os dados, automaticamente os mesmos são enviados para o controlador.6P  5z   #   5|      5}      5�      5�      5�      5�      +  %MahApps.Metro.Controls.FlyoutsControl  5�   
   $
��1146��6#   .@�5�      #  MahApps.Metro.Controls.Flyout     Position$	 Top=�6      IsAutoCloseEnabled .    AutoCloseInterval$
 3000��6G   $��45��6`      CloseButtonVisibility$ 	Collapsed=�6�      IsOpen 6m   �� *MostrarMensagem+.��5�      �� $ 
Horizontal=�6   $��Center=�66   $��Center=�6Q   .+�5�      	  $��Center=�65   $��0 0 10 0q�6R   $ CheckCircle=�6d     MahApps.Brushes.Accent#���  6w   $��20��6�   $��20��6�   �� 5�      $��16(�6    $��Center=�6.   ��6I   �� *ConteudoMensagem+6m   5�      5�      5�      5�      5�      