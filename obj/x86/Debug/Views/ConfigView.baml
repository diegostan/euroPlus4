   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5       euroPlus4_1"   euroPlus4_1.Views.ConfigView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      ;controls,http://metro.mahapps.com/winfx/xaml/controls   5      :d2http://schemas.microsoft.com/expression/blend/2008   5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5      ^ ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af	 bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj
 fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   	 
                   5	        N� Title$  
ConfigView��5       � 	Resources 5      ��%    5      .��5      � $	��698��6   .+�5   
   �� $��Stretch=�6   $��Stretch=�63   $
��1146��6O   $	��698��6\   .+�5      �� $��45��6   $��Stretch=�6%   $
��1148��6D   $��-1 0 0 0q�6Q   .+�5      �� $��10q�6   $��20(�6(    �� TextAlignment$ Center=�66   $��Center=�6M   
�������Configurações6�   5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  5      $��0q�62   $	��653��6>   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffects 5      ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5         Kind$ FadeIn=�66      Duration$ 0:0:0.8h�6D   .��5      � $��10q�6   .+�5       4   .MahApps.Metro.Controls.MetroAnimatedTabControl  -   'MahApps.Metro.Controls.TabControlHelper   
Underlined$ TabPanel=�6Q   ��6;   Z� .@�5"      )   #MahApps.Metro.Controls.MetroTabItem  $��
 máquina ��64    �� 
IsSelected . ��6Y   Z� .��5#      �� $	��584��6)   $��10q�66    �� Orientation$ 
Horizontal=�6B   .+�5$   "   �� $	��900��6-   .+�5%   &   �� $��5q�60   $��18(�6;   $��SemiBold"�6I   
�������Informações iniciais6�   �� 5&   &   $��5q�60   $��Light"�6;   
�������Nome da máquina6r   �� 5'   &   *   $MahApps.Metro.Controls.TextBoxHelper	   SelectAllOnFocus	 . 
   ClearTextButton
 . $	��350��6�   $
��Left=�6�   ��6.   �� *" ConfigMaquinaModel.NomeDaMaquina+6�   �� 5(   &   $��5q�60   $��Light"�6;   
�������Posição na planta6t   �� 5)   &   	 . 
 . $	��350��6�   $
��Left=�6�   ��6.   �� *$"ConfigMaquinaModel.PosicaoNaPlanta+6�   �� 5*   &   $��5q�60   $��Light"�6;   
�������Número de série6r   �� 5+   &   	 . 
 . $	��350��6�   $
��Left=�6�   ��6.   �� *" ConfigMaquinaModel.NumeroDeSerie+6�   �� 5,   &   $��5q�60   $��Light"�6;   
�������Tensão de entrada (em volts)6   �� 5-   &   	 . $	��350��6`   $
��Left=�6l   ��6�   �� *$"ConfigMaquinaModel.TensaoDeEntrada+ �� SelectedIndex 6�   �� */-ConfigMaquinaModel.TensaoDeEntradaSelecionado+6  �� 5.   &   $��5q�61   $��Light"�6<   
�������
Fabricante6n   �� 5/   &   	 . 
 . $	��350��6�   $
��Left=�6�   ��6.   �� *ConfigMaquinaModel.Fabricante+6�   �� 50   &   $��5q�60   $��Light"�6;   
�������Ano de fabricação6t   (  "System.Windows.Controls.DatePicker  51   &   $	��350��6m   $
��Left=�6y      	Watermark$ Escolha a data��6�    � 
InputScope$
 Date��6�      SelectedDateFormat$ Short=�6�      SelectedDate 61   �� *$"ConfigMaquinaModel.AnoDeFabricacao+6�   �� 52   &   $��5q�60   $��Light"�6;   
�������Tipo de aplicação6t   �� 53   &   $	��350��6/   $
��Left=�6;   ��6V   �� *$"ConfigMaquinaModel.TipoDeAplicacao+ 6�   �� */-ConfigMaquinaModel.TipoDeAplicacaoSelecionado+6�   �� 55   &   $ 
Horizontal=�61   $��0 20 0 0q�6J   $��Center=�6\   .+�56   *   �� $��Center=�65   .+�57   .   �� $��Medium"�69   $��12(�6N   
�������Salvar os dados6�   �� 58   .   $��Light"�69   $��12(�6L   
�������'%Após as alterações, salve os dados6�   59   +   �� 5:   *   $	��0.1q�61   $
��auto��6G   $��16(�6V   $��Medium"�6d   $
��Left=�6x   $��10 0 0 0q�6�   $
��auto��6�    J� Opacity$
 0.66Q�6�    ,  (MahApps.Styles.Button.MetroSquare.Accent#���   6�   
���������6  �� *SalvarDadosDaMaquina+��5;   .   �� 5<   2   $ 
Horizontal=�6=   $��0q�6V   .+�5=   6   .	  (MahApps.Metro.IconPacks.PackIconMaterial	  $��Center=�6Q   $��8q�6n    	  Kind$ ContentSaveAll=�6y   
�������$��25��6�   $��25��6�   �� 5>   6   $��5q�6@   $��Center=�6K   Salvar dados6t   5?   3   5A   +   5B   '   5D      �� 5F   "   $	��206��6-   .+�5G   &   �� $��5q�61   $ 
Horizontal=�6<   $
��Left=�6U   .+�5H   *   '
  !MaterialDesignThemes.Wpf.PackIcon
   
  Kind$ Tools=�6B   $��20��6O   $��20��6[   
�������$��Center=�6y   �� 5I   *   $��5q�64   $��Medium"�6?   $��12(�6S   
�������$��Center=�6t   Obtenhá-se atualizado6�   5J   '   �� 5K   &   $
 Left=�60   $��5q�6E   $��Light"�6P   $��11(�6c   
�������$
��Wrap=�6�   ��Mantenha as informações de máquina sempre atualizadas, isso ajuda o euroPlus a sempre obter as melhores atualizações para seu equipamento, não esqueça de salvar as alterações após fazê-las.6W  �� 5M   &   $��	5 20 0 0 q�61   $ 
Horizontal=�6D   $
��Left=�6]   .+�5N   *   
  $ ViewDashboard=�6B   $��20��6W   $��20��6c   
�������$��Center=�6�   �� 5O   *   $��5q�64   $��Medium"�6?   $��12(�6S   
�������$��Center=�6t   	Dashboard6�   5P   '   �� 5Q   &   $
 Left=�60   $��5q�6E   $��Light"�6P   $��11(�6c   
�������$
��Wrap=�6�   PNApresente os dados de fabricante e modelo da máquina na tela de visão geral.6�   5S   #   5U      5V        5X      $��	 sistema ��60   ��6C   Z� .��5Y      �� $��10,10,-10,-10q�6+   $
��Auto=�6C   $
��auto��6f   ��. .��5Z   "   �� $
��auto��6-   $��	00 0 0 0 q�6;   $ 
Horizontal=�6O   .+�5\   &   �� $	��900��61   .+�5]   *   �� $��5q�64   $��18(�6?   $��SemiBold"�6M   
�������Informações de software6�   �� 5^   *   $ 
Horizontal=�65   .+�5_   .   �� $	��180��69   .+�5`   2   �� $��5q�6<   $��Light"�6G   
������� Número de série do euroPlus:6�   �� 5a   2   $��5q�6<   $��Light"�6G   
�������Firmware do PLC:6   �� 5b   2   $��5q�6<   $��Light"�6G   
�������Data atualização:6�   �� 5c   2   $��5q�6<   $��Light"�6G   
�������Fabricante PLC:6~   5d   /   �� 5e   .   .+�5f   2   �� $��5q�6<   $��Medium"�6G   
�������KFJF3-JG9H3-NGKBO-D3NDM-JDNHR6�   �� 5g   2   $��5q�6<   $��Medium"�6G   
�������ER 202012.34 SE6�   �� 5h   2   $��5q�6<   $��Medium"�6G   
�������
01/07/20206}   �� 5i   2   $��5q�6<   $��Medium"�6G   
�������BECKHOFF AUTOMAÇÃO IND.6�   5j   /   5k   +   �� 5l   *   $��	5 20 0 5 q�64   $��18(�6G   $��SemiBold"�6U   
�������!Especificações do dispositivo6�   �� 5m   *   $ 
Horizontal=�65   .+�5n   .   �� $	��180��69   .+�5o   2   �� $��5q�6<   $��Light"�6G   
�������Nome do dispositivo:6�   �� 5p   2   $��5q�6<   $��Light"�6G   
�������Processador:6{   �� 5q   2   $��5q�6<   $��Light"�6G   
�������Memória instalada:6�   �� 5r   2   $��5q�6<   $��Light"�6G   
�������Nome da BIOS:6|   �� 5s   2   $��5q�6<   $��Light"�6G   
�������ID do produto:6}   �� 5t   2   $��5q�6<   $��Light"�6G   
�������Tipo de sistema:6   �� 5u   2   $��5q�6<   $��Light"�6G   
�������Tamanho do disco:6�   5v   /   �� 5w   .   .+�5x   2   �� $��5q�6<   $��Medium"�6G   
���������6q   �� *NomeDispositivo+6�   �� 5y   2   $��5q�6<   $��Medium"�6G   
���������6q   �� *Processador+6�   �� 5z   2   $��5q�6<   $��Medium"�6G   
���������6q   �� *MemoriaInstalada+6�   �� 5{   2   $��5q�6<   $��Medium"�6G   
���������6q   �� *
NomeBIOS+6�   �� 5|   2   $��5q�6<   $��Medium"�6G   
���������6q   �� *IDdoProduto+6�   �� 5}   2   $��5q�6<   $��Medium"�6G   
���������6q   �� *TipoSistema+6�   �� 5~   2   $��5q�6<   $��Medium"�6G   
���������6q   �� *TamanhoDisco+6�   5   /   5�   +   �� 5�   *   $��	5 20 0 5 q�64   $��18(�6G   $��SemiBold"�6U   
�������Configurações do euroPlus6�   �� 5�   *   $��	0 10 0 20q�65   .+�5�   .   �� $ Vertical=�69   .+�5�   2   �� $��5q�6<   $��Medium"�6G   
�������$��14(�6n   Tema:6�   �� 5�   2   $	��438��6x   $��40��6�   $
��Left=�6�    ' #MahApps.Styles.ComboBox.Virtualized#���  6�   ���	#FFDEDEDE��6;   �� *%#ConfigSistemaModel.TemasDisponiveis+ �� Text 6  �� *
ModoEscuro+ 6  �� *$"ConfigSistemaModel.TemaSelecionado+�� 5�   2   $��	 2 15 0 5q�6;   $
��Bold"�6N   $*��$Aplicar modo escuro automaticamente ��6`    % !MahApps.Styles.CheckBox.DataGrid.#���  6�   
�������
����������	#FFB2B2B2 d� 	IsChecked 6	  �� *53ConfigSistemaModel.AplicarModoEscuroAutomaticamente+6U  �� 5�   2   $ Vertical=�6=   .+�5�   6   �� $��5q�6@   $��Light"�6K   
�������Inicio6y   '   !MahApps.Metro.Controls.TimePicker  5�   6   +   %MahApps.Metro.Controls.TimePickerBase   SelectedTimeFormat$ Short=�6�      Culture$ pt-BR��6�   $ Hora inicial��6�   $	��438��6�   $��40��6�   $
��Left=�6�      SelectedDateTime 6E   �� * ConfigSistemaModel.HoraInicial+{�6
  �� *53ConfigSistemaModel.AplicarModoEscuroAutomaticamente+6W  �� 5�   6   $��5q�6@   $��Light"�6K   
�������	Termino6z     5�   6   $ Short=�6   $ pt-BR��6�   $ 
Hora final��6�   $	��438��6�   $��40��6�   $
��Left=�6�    6E   �� *ConfigSistemaModel.HoraFinal+{�6  �� *53ConfigSistemaModel.AplicarModoEscuroAutomaticamente+6R  5�   3   �� 5�   2   $��5q�6<   $��Medium"�6G   
�������$��14(�6n   Selecionar cor de destaque:6�   �� 5�   2   $	��438��6=   $��40��6I   $
��Left=�6�   #���  6�   ���	#FFDEDEDE��6U   �� *%#ConfigSistemaModel.CoresDisponiveis+ 6  �� *CorDeDestaque+ 6!  �� *-+ConfigSistemaModel.CorDeDestaqueSelecionado+5�   /   5�   +   �� 5�   *   $ 
Horizontal=�65   $��Center=�6N   $��	 0 0 0 10q�6i   .+�5�   *   �� $��Center=�65   .+�5�   2   �� $��Medium"�6=   
�������Salve o tema selecionado6�   �� 5�   *   $��Light"�65   
�������75Após as alterações, confira e salve das suas cores6�   5�   +   �� 5�   .   $	��0.1q�65   $
��auto��6K   $��16(�6Z   $��Medium"�6h   $
��Left=�6|   $��25 0 0 0q�6�   $
��auto��6�   $
 0.66Q�6�   #���   6�   
���������6  �� *SelecionarTema+��5�   .   �� 5�   2   $ 
Horizontal=�6=   $��0q�6V   .+�5�   6   	  $��Center=�6Q   $��8q�6n   $ Brush=�6y   
�������$��25��6�   $��25��6�   �� 5�   :   $��5q�6D   $��Center=�6O   Aplicar tema6x   5�   3   5�   +   5�   ,   �� 5�   *   $ 
Horizontal=�65   $��0 0 0 20q�6N   $��Center=�6`   .+�5�   .   �� $��Center=�69   .+�5�   2   �� $��Medium"�6=   
�������Salvar os dados6w   �� 5�   2   $��Light"�6=   
�������'%Após as alterações, salve os dados6�   5�   /   �� 5�   .   $	��0.1q�65   $
��auto��6K   $��16(�6Z   $��Medium"�6h   $
��Left=�6|   $��98 0 0 0q�6�   $
��auto��6�   $
 0.66Q�6�   #���   6�   
���������6  �� *SalvarDadosDaMaquina+��5�   2   �� 5�   6   $ 
Horizontal=�6A   $��0q�6Z   .+�5�   :   	  $��Center=�6U   $��8q�6r   $ ContentSaveAll=�6}   
�������$��25��6�   $��25��6�   �� 5�   :   $��5q�6D   $��Center=�6O   Salvar dados6x   5�   7   5�   /   5�   +   5�   '   �� 5�   &   $	��206��61   .+�5�   *   �� $��5q�65   $ 
Horizontal=�6@   $
��Left=�6Y   .+�5�   .   
  $ SettingsApplications=�6F   $��20��6b   $��20��6n   
�������$��Center=�6�   �� 5�   .   $��5q�68   $��Medium"�6C   $��12(�6W   
�������$��Center=�6x   Informações de sistema6�   5�   +   �� 5�   *   $
 Left=�64   $��5q�6I   $��Light"�6T   $��11(�6g   
�������$
��Wrap=�6�   ��Acompanhe e visualize as informações correntes do sistema instalado, assim como informações de CPU, memória e números de série do sistema e hardware.63  �� 5�   *   $��	5 20 0 0 q�65   $ 
Horizontal=�6H   $
��Left=�6a   .+�5�   .   
  $ SettingsSync=�6F   $��20��6Z   $��20��6f   
�������$��Center=�6�   �� 5�   .   $��5q�68   $��Medium"�6C   $��12(�6W   
�������$��Center=�6x   Configurar o euroPlus6�   5�   +   �� 5�   *   $
 Left=�64   $��5q�6I   $��Light"�6T   $��11(�6g   
�������$
��Wrap=�6�   }Modifique aspectos e preferências do euroPlus além habilitar e desabilitar recursos do sistema de forma prática e rápida.6  5�   '   5�   #   5�      5�        5�      $�� comunicação ��60   $��Right=�6]   $	��182��6y   ��6G   Z� .��5�      �� $��10,10,-10,-10q�6+   $
��Auto=�6C   $
��auto��6f   .��5�   "   �� $
��auto��6-   $��	00 0 0 0 q�6;   $ 
Horizontal=�6O   .+�5�   &   �� $	��900��61   .+�5�   *     $ TabPanel=�6a   $��8(�6�    �� TabStripPlacement$	 Top=�6�   ��6K   Z� .@�5�   .     $��
 ethernet ��6D   $��8(�6n   ��6X   Z� .��5�   2   �� .+�5�   6   �� $��5q�6@   $��18(�6K   $��SemiBold"�6Y   
�������Configurações de canal6�   �� 5�   6   $��12(�6@   $��5q�6N   $��Light"�6Y   
�������	Protocolo6�   �� 5�   6   	 . $	��350��6�   $
��Left=�6
  ��6?   �� **(ConfigComunicacaoModel.ProtocoloEthernet+ 6�   �� *53ConfigComunicacaoModel.ProtocoloEthernetSelecionado+6'  �� 5�   6   $��12(�6@   $��5q�6N   $��Light"�6Y   
�������Endereço IP6�   �� 5�   6   	 . 
 . $	��350��6�   $
��Left=�6�   ��6>   �� *#!ConfigComunicacaoModel.EnderecoIP+6�   �� 5�   6   $��12(�6@   $��5q�6N   $��Light"�6Y   
�������Porta6�   �� 5�   6   	 . 
 . $	��350��6�   $
��Left=�6�   ��6>   �� *ConfigComunicacaoModel.Porta+6�   �� 5�   6   $��12(�6@   $��5q�6N   $��Light"�6Y   
�������&$Tempo de atualização (milisegundo)6�   *   $MahApps.Metro.Controls.NumericUpDown  5�   6   	 .    UpDownButtonsWidth$ 30Q�6�      Minimum$ 50Q�6�   $��40��6�   $��18(�6�      Maximum$
 1000Q�6�   $	��350��6  $
��Left=�6     Value 6M   �� *-+ConfigComunicacaoModel.TempoLeituraEthernet+61  �� 5�   6   $	��0.1q�6=   $
��auto��6S   $��16(�6b   $��Medium"�6p   $
��Left=�6�   $��0 20 0 0q�6�   $	��350��6�   $
 0.66Q�6�   #���   6�   
���������6"  �� *TestarConexaoEtherCAT+��5�   >   �� 5�   B   $ 
Horizontal=�6M   $��0q�6f   .+�5�   F   	  $��Center=�6a   $��8q�6~   $ Ethernet=�6�   
�������$��25��6�   $��25��6�   �� 5�   B   $��5q�6L   $��Center=�6W   Salvar e testar comunicação6�   5�   C   5�   ;   5�   3   5�   /     5�   .   $�� serial ��6D   $��8(�6l   ��6V   Z� .��5�   2   �� .+�5�   6   �� $��5q�6@   $��18(�6K   $��SemiBold"�6Y   
�������Configurações de porta6�   �� 5�   6   $��12(�6@   $��5q�6N   $��Light"�6Y   
�������	Protocolo6�   �� 5�   6   	 . $	��350��6�   $
��Left=�6  ��6?   �� *(&ConfigComunicacaoModel.ProtocoloSerial+ 6~   �� *31ConfigComunicacaoModel.ProtocoloSerialSelecionado+6#  �� 5�   6   $��12(�6@   $��5q�6N   $��Light"�6Y   
�������
BaudRate6�   �� 5�   6   	 . $	��350��6�   $
��Left=�6�   ��6?   �� *!ConfigComunicacaoModel.BaudRate+ 6w   �� *,*ConfigComunicacaoModel.BaudRateSelecionado+6  �� 5�   6   $��12(�6@   $��5q�6N   $��Light"�6Y   
�������
Stop bit6�   �� 5�   6   	 . $	��350��6�   $
��Left=�6�   ��6?   �� * ConfigComunicacaoModel.StopBit+ 6v   �� *+)ConfigComunicacaoModel.StopBitSelecionado+6  �� 5�   6   $��12(�6@   $��5q�6N   $��Light"�6Y   
�������
Paridade6�   �� 5�   6   	 . $	��350��6�   $
��Left=�6�   ��6?   �� *!ConfigComunicacaoModel.Paridade+ 6w   �� *,*ConfigComunicacaoModel.ParidadeSelecionado+6  �� 5�   6   $��12(�6@   $��5q�6N   $��Light"�6Y   
�������Número da estação6�   �� 5�   6   	 . 
 . $	��350��6�   $
��Left=�6�   ��6>   �� *&$ConfigComunicacaoModel.NumeroEstacao+6�   �� 5�   6   $	��0.1q�6=   $
��auto��6S   $��16(�6b   $��Medium"�6p   $
��Left=�6�   $��0 20 0 0q�6�   $	��350��6�   $
 0.66Q�6�   #���   6�   
���������5�   :   �� 5�   >   $ 
Horizontal=�6I   $��0q�6b   .+�5�   B   	  $��Center=�6]   $��8q�6z   $ 
SerialPort=�6�   
�������$��25��6�   $��25��6�   �� 5�   B   $��5q�6L   $��Center=�6W   Salvar e testar comunicação6�   5�   ?   5�   7   �� 5�   6   $ 
Horizontal=�6A   $��0 20 0 0q�6Z   $��Center=�6l   .+�5�   :   �� $��Center=�6E   .+�5�   >   �� $��Medium"�6I   $��12(�6]   
�������Salvar os dados6�   �� 5�   >   $��Light"�6I   $��12(�6\   
�������'%Após as alterações, salve os dados6�   5�   ;   �� 5�   :   $	��0.1q�6A   $
��auto��6W   $��16(�6f   $��Medium"�6t   $
��Left=�6�   $��10 0 0 0q�6�   $
��auto��6�   $
 0.66Q�6�   #���   6�   
���������6'  �� *SalvarDadosDaMaquina+��5   >   �� 5  B   $ 
Horizontal=�6M   $��0q�6f   .+�5  F   	  $��Center=�6a   $��8q�6~   $ ContentSaveAll=�6�   
�������$��25��6�   $��25��6�   �� 5  F   $��5q�6P   $��Center=�6[   Salvar dados6�   5  C   5  ;   5  7   5	  3   5
  /     5  .   $�� variáveis ��6D   $��8(�6o   ��6Y   Z� .��5  2   �� .+�5  6   �� $��5q�6@   $��18(�6K   $��SemiBold"�6Y   
�������*(Controle de variáveis do sistema remoto6�   �� 5  6   $��12(�6@   $��5q�6N   $��Light"�6Y   
�������Tipo de variável6�   �� 5  6   	 . $	��350��6o   $
��Left=�6{   $��20��6�   .@�5  :   �� $��discreto��6H    �� 
IsSelected . 6[   �� 5  :   $��inteiro��6G   �� 5  :   $��string��6G   $
��auto��6X   5  7   �� 5  6   $��12(�6@   $��5q�6N   $��Light"�6Y   
�������Canal6�   �� 5  6   	 . $	��350��6o   $
��Left=�6{   $��20��6�   .@�5  :   �� $��ethernet��6G    . 6Z   �� 5  :   $��serial��6G   5  7   �� 5  6   $��12(�6@   $��5q�6N   $��Light"�6Y   
�������!Nome da variável (sem espaço)6�   �� 5  6   	 . 
 . $	��350��6�   $
��Left=�6�   6�   �� 5  6   $��12(�6@   $��5q�6N   $��Light"�6Y   
�������@>Endereço no controlador (ou nome de variável do controlador)6�   �� 5  6   	 . 
 . $	��350��6�   $
��Left=�6�   6�   �� 5  6   $	��0.1q�6c   $
��auto��6y   $��16(�6�   $��Medium"�6�   $
��Left=�6�   $��	0 20 0 10q�6�   $	��350��6�   $
 0.66Q�6�   #���   6�   
���������6=   �� *AdicionarVariavel+��5  :   �� 5   >   $ 
Horizontal=�6I   $��0q�6b   .+�5!  B   	  $��Center=�6]   $��8q�6z   $ VariableBox=�6�   
�������$��25��6�   $��25��6�   �� 5"  B   $��5q�6L   $��Center=�6W   Criar variável6�   5#  ?   5%  7   �� 5'  6   $��5q�6@   $��18(�6K   $��SemiBold"�6Y   
�������&$Remover variáveis do sistema remoto6�   �� 5)  6   $��12(�6@   $��5q�6N   $��Light"�6Y   
������� ID da variável a ser removida6�     5*  6   	 . $ 0Q�6}   $	��350��6�   $
��Left=�6�   6�   �� 5,  6   $	��0.1q�6a   $
��auto��6w   $��16(�6�   $��Medium"�6�   $
��Left=�6�   $��	0 20 0 10q�6�   $	��350��6�   $
 0.66Q�6�   #���   6�   
���������6=   �� *RemoverVariavel+��5-  :   �� 5.  >   $ 
Horizontal=�6I   $��0q�6b   .+�5/  B   	  $��Center=�6]   $��8q�6z   $ Eraser=�6�   
�������$��25��6�   $��25��6�   �� 50  B   $��5q�6L   $��Center=�6W   Remover variável6�   51  ?   53  7   �� 55  6   $��5q�6@   $��18(�6K   $��SemiBold"�6Y   
�������Variáveis do sistema remoto6�   �� 56  6   $��12(�6@   $��5q�6N   $��Light"�6Y   
�������Variáveis declaradas6�   &   System.Windows.Controls.DataGrid  57  6      AutoGenerateColumns .  $
��Left=�6�     MahApps.Styles.DataGrid#���  6�      HeadersVisibility$ Column=�6�       SelectionUnit$
  Cell=�6�   $��5q�6   $��12(�6  !   GridLinesVisibility$
! None=�6  $	��280��64  "   CanUserAddRows" .  #   CanUserResizeColumns# .  $   CanUserDeleteRows$ .  $
��auto��6�  ��6?   �� *TabelaVariaveis+%   Columns% 58  :   0  *System.Windows.Controls.DataGridTextColumn  59  >   ,  &System.Windows.Controls.DataGridColumn&   Header$& ID��6i   1  +System.Windows.Controls.DataGridBoundColumn'   Binding' 6Q   �� *ID+6i     5:  >   $
& Tipo��6k   ' 6Q   �� *Tipo+6k     5;  >   $
& Nome��6j   (   FontSize$( 12Q�6x   ' 6Q   �� *Nome+6x     5<  >   $& Canal��6k   $( 12Q�6z   ' 6Q   �� *Canal+6z     5=  >   $& 	Endereço��6n   $( 12Q�6�   ' 6Q   �� *
Endereco+6�     5>  >   $& Leitura��6m   $( 12Q�6~   ' 6Q   �� *	Leitura+6~   4  .System.Windows.Controls.DataGridCheckBoxColumn  5?  >   $& Ativo��6o   ' 6U   �� *Ativo+6o   5A  7   5B  3   5C  /   5D  +   5E  '   �� 5F  &   $	��206��61   .+�5G  *   �� $��5q�65   $ 
Horizontal=�6@   $
��Left=�6Y   .+�5H  .   
  $ EthernetCable=�6F   $��20��6[   $��20��6g   
�������$��Center=�6�   �� 5I  .   $��5q�68   $��Medium"�6C   $��12(�6W   
�������$��Center=�6x   Configuração ethernet6�   5J  +   �� 5K  *   $
 Left=�64   $��5q�6I   $��Light"�6T   $��11(�6g   
�������$
��Wrap=�6�   ��Nas configurações ethernet é possível fazer o euroPlus 4 se comunicar por diversos protocolos disponíveis nesse meio físico, o IP e a Porta deverão corresponder em ambos os equipamentos.6X  �� 5M  *   $��	5 20 0 0 q�65   $ 
Horizontal=�6H   $
��Left=�6a   .+�5N  .   
  $ 
SerialPort=�6F   $��20��6X   $��20��6d   
�������$��Center=�6�   �� 5O  .   $��5q�68   $��Medium"�6C   $��12(�6W   
�������$��Center=�6x   Configuração serial6�   5P  +   �� 5Q  *   $
 Left=�64   $��5q�6I   $��Light"�6T   $��11(�6g   
�������$
��Wrap=�6�   ��A configuração serial permite o uso de portas como RS232 e RS485 para comunicação com equipamentos mais antigos ou simples, lembrando sempre que a comunicação serial apresenta valores de leitura e escrita inferiores ao ethernet, é possível utilizar os dois meios fisicos simultaneamente.6�  �� 5S  *   $��	5 20 0 0 q�65   $ 
Horizontal=�6H   $
��Left=�6a   .+�5T  .   
  $ VariableBox=�6F   $��20��6Z   $��20��6f   
�������$��Center=�6�   �� 5U  .   $��5q�68   $��Medium"�6C   $��12(�6W   
�������$��Center=�6x   
Varíaveis6�   5V  +   �� 5W  *   $
 Left=�64   $��5q�6I   $��Light"�6T   $��11(�6g   
�������$
��Wrap=�6�   ��O sistema permite que o usuário crie variáveis de comunicação com o controlador para associação com os campos disponíveis. É possível a troca de variáveis em qualquer campo de configuração da máquina desde que esse campo tenha compatibilidade de tipo e range de variação.6�  5Y  '   5[  #   5\     5]       5_     $�� banco de dados ��60   ��6J   Z� .��5`     �� $	��584��6)   $��10q�66   $ 
Horizontal=�6B   .+�5a  "   �� $	��900��6-   .+�5b  &   �� $��5q�60   $��18(�6;   $��SemiBold"�6I   
�������(&Configuração do banco de dados local6�   �� 5c  &   $��5q�60   $��Light"�6;   
�������Tipo de banco de dados6y   �� 5d  &   	 . $	��350��6�   $
��Left=�6�   ��6/   �� *#!ConfigDadosModel.TipoBancoDeDados+ 6i   �� *.,ConfigDadosModel.TipoBancoDeDadosSelecionado+6	  �� 5e  &   $��5q�60   $��Light"�6;   
�������Endereço provedor6t   �� 5f  &   	 . 
 . $	��350��6�   $
��Left=�6�   ��6.   �� *#!ConfigDadosModel.EnderecoProvedor+6�   �� 5g  &   $��5q�60   $��Light"�6;   
�������
Usuário6j   �� 5h  &   	 . 
 . $	��350��6�   $
��Left=�6�   ��6.   �� *ConfigDadosModel.Usuario+6�   �� 5i  &   $��5q�60   $��Light"�6;   
�������Senha6h   �� 5j  &   	 . $	��350��6�   $
��Left=�6�   
 . ��6/   �� *ConfigDadosModel.Senha+6�   �� 5k  &   $��5q�60   $��Light"�6;   
�������Banco de dados do euroPlus6}   �� 5l  &   -   5        ) ��Name$) txtNomeBancoEuroPlus��5l  .   	 . $	��350��6�   $
��Left=�6�   
 . ��6L   �� *" ConfigDadosModel.NomeBaseDeDados+6  �� 5m  &   $��5q�60   $��Light"�6;   
�������Bancos de dados disponíveis6~   �� 5n  &   $	��350��6k   $
��Left=�6w   ��6/   �� *$"ConfigDadosModel.BancosDisponiveis+6�   �� 5q  &   $	��0.1q�6-   $
��auto��6C   $��16(�6R   $��Medium"�6`   $
��Left=�6t   $��0 20 0 0q�6�   $	��350��6�   $
 0.66Q�6�   #���   6�   
���������6  �� *TestarConexaoBancoDeDados+��5r  *   �� 5s  .   $ 
Horizontal=�69   $��0q�6R   .+�5t  2   	  $��Center=�6M   $��8q�6j   $ DatabaseCheck=�6u   
�������$��25��6�   $��25��6�   �� 5u  2   $��5q�6<   $��Center=�6G   Salvar e testar conexão6{   5v  /   5x  '   �� 5y  &   $ 
Horizontal=�61   .+�5z  &   �� $	��0.1q�6-   $
��auto��6C   $��16(�6R   $��Medium"�6`   $
��Left=�6t   $��0 20 0 0q�6�   $	��350��6�   $
 0.66Q�6�   #���   6�   
�������{�6�   �� * ConfigDadosModel.BancoEuroPlus+��6G  �� *CriarEstruraDeDados+��5{  *   �� 5|  .   $ 
Horizontal=�69   $��0q�6R   .+�5}  2   	  $��Center=�6M   $��8q�6j   $ Creation=�6u   
�������$��25��6�   $��25��6�   �� 5~  2   $��5q�6<   $��Center=�6G   Criar estrutura de dados6|   5  /   5�  '     5�  *   $��0q�6N   $
��auto��6Z   y�6h   �� *+)ConfigDadosModel.BancoEuroPlusProcessando+ 5�  .     5�  2   $ FadeIn=�6R   $ 0:0:0.8h�6`   .��5�  .   �� $ 
Horizontal=�69   .+�5�  .   )   #MahApps.Metro.Controls.ProgressRing  $��20 0 0 8q�6?   $��Bottom=�6Q   $��30��6l   $��30��6x   6�   �� 5�  .   
�������$��14(�6K   $��Bottom=�6Y   $��	15 0 0 15q�6t   
Aguarde...6�   5�  /   5�  +   5�  '   �� 5�  &   $ 
Horizontal=�61   $��
-8 15 0 10q�6J   .+�5�  *   2  ,MahApps.Metro.IconPacks.PackIconFeatherIcons  $��Center=�6I   $��8q�6f   *   Kind$* AlertCircle=�6q   
����p��$��23��6�   $��23��6�   $��Center=�6�   �� 5�  *   $��0 0 0 0q�64   $	��320��6E   $
��Wrap=�6T   $
��Left=�6h   $��Regular"�6�   $��14(�6�   
����p��$��Center=�6�   caCuidado ao criar uma nova estrutura de dados, certifique-se de que os dados não serão perdidos.6=  5�  '   5�  #   �� 5�  "   $	��206��6-   .+�5�  &   �� $��5q�61   $ 
Horizontal=�6<   $
��Left=�6U   .+�5�  *   
  $ Database=�6B   $��20��6R   $��20��6^   
�������$��Center=�6|   �� 5�  *   $��5q�64   $��Medium"�6?   $��12(�6S   
�������$��Center=�6t   Variadas bases de dados6�   5�  '   �� 5�  &   $
 Left=�60   $��5q�6E   $��Light"�6P   $��11(�6c   
�������$
��Wrap=�6�   ��Graças as suas ferramentas de escalabilidade, o euroPlus 4 é capaz de fornecer conexão com diversos tipos de banco de dados, SQL Server, Oracle, Postgress(esse, o padrão) entre outros futuros e não mencionados, sempre visando a maior flexibilidade possível e os recursos disponíveis nas companhias.6�  �� 5�  &   $��	5 20 0 0 q�61   $ 
Horizontal=�6D   $
��Left=�6]   .+�5�  *   
  $ DatabasePlus=�6B   $��20��6V   $��20��6b   
�������$��Center=�6�   �� 5�  *   $��5q�64   $��Medium"�6?   $��12(�6S   
�������$��Center=�6t   Ampliação de dados6�   5�  '   �� 5�  &   $
 Left=�60   $��5q�6E   $��Light"�6P   $��11(�6c   
�������$
��Wrap=�6�   ��Se ao invés de utilizar-se apenas uma base de dados, utilizassemos duas, três ou mais bases diferentes ? Isso será possível no euroPlus 4, varias instâncias, vários modelos, tudo em um único sistema.6a  5�  #   5�     5�       5�     $�� IoT ��60   {�.  ��6?   Z� .��5�     �� $	��584��6)   $��10q�66   $ 
Horizontal=�6B   .+�5�  "   �� $	��900��6-   .+�5�  &   �� $��5q�60   $��18(�6;   $��SemiBold"�6I   
������� Configuração de transmissão6�   �� 5�  &   $��5q�60   $��Light"�6;   
�������Tipo de provedor6s   �� 5�  &   	 . $	��350��6`   $
��Left=�6l   6�   �� 5�  &   $��5q�60   $��Light"�6;   
�������Endereço provedor6t   �� 5�  &   	 . 
 . $	��350��6�   $
��Left=�6�   6�   �� 5�  &   $��5q�60   $��Light"�6;   
�������
Usuário6j   �� 5�  &   	 . 
 . $	��350��6�   $
��Left=�6�   6�   �� 5�  &   $��5q�60   $��Light"�6;   
�������Senha6h   G� 5�  &   	 . $	��350��6c   $
��Left=�6o   
 . 6�   �� 5�  &   $��5q�60   $��Light"�6;   
�������Nome da base de dados6x   �� 5�  &   	 . 
 . $	��350��6�   $
��Left=�6�   6�   �� 5�  &   $��5q�60   $��Light"�6;   
�������Porta6h     5�  &   	 . $	��350��6m   $
��Left=�6y   $ 0Q�6�   $
 9999Q�6�   6�   �� 5�  &   $	��0.1q�6-   $
��auto��6C   $��16(�6R   $��Medium"�6`   $
��Left=�6t   $��0 20 0 0q�6�   $	��350��6�   $
 0.66Q�6�   #���   6�   
���������5�  *   �� 5�  .   $ 
Horizontal=�69   $��0q�6R   .+�5�  2   	  $��Center=�6M   $��8q�6j   $ DatabaseCheck=�6u   
�������$��25��6�   $��25��6�   �� 5�  2   $��5q�6<   $��Center=�6G   Salvar e testar conexão6{   5�  /   5�  '   5�  #   �� 5�  "   $	��206��6-   .+�5�  &   �� $��5q�61   $ 
Horizontal=�6<   $
��Left=�6U   .+�5�  *   
  $ Database=�6B   $��20��6R   $��20��6^   
�������$��Center=�6|   �� 5�  *   $��5q�64   $��Medium"�6?   $��12(�6S   
�������$��Center=�6t   Variadas bases de dados6�   5�  '   �� 5�  &   $
 Left=�60   $��5q�6E   $��Light"�6P   $��11(�6c   
�������$
��Wrap=�6�   ��Graças as suas ferramentas de escalabilidade, o euroPlus 4 é capaz de fornecer conexão com diversos tipos de banco de dados, SQL Server, Oracle, Postgress(esse, o padrão) entre outros futuros e não mencionados, sempre visando a maior flexibilidade possível e os recursos disponíveis nas companhias.6�  �� 5�  &   $��	5 20 0 0 q�61   $ 
Horizontal=�6D   $
��Left=�6]   .+�5�  *   
  $ DatabasePlus=�6B   $��20��6V   $��20��6b   
�������$��Center=�6�   �� 5�  *   $��5q�64   $��Medium"�6?   $��12(�6S   
�������$��Center=�6t   Ampliação de dados6�   5�  '   �� 5�  &   $
 Left=�60   $��5q�6E   $��Light"�6P   $��11(�6c   
�������$
��Wrap=�6�   ��Se ao invés de utilizar-se apenas uma base de dados, utilizassemos duas, três ou mais bases diferentes ? Isso será possível no euroPlus 4, varias instâncias, vários modelos, tudo em um único sistema.6a  5�  #   5�     5�       5�     $�� nuvem ��60   {�.  ��6A   Z� .��5�     � $	��584��6#   $��10q�60   .+�5�  "   �� 26/   5�     5�     5�     5�     5�     5�     +   %MahApps.Metro.Controls.FlyoutsControl  5�  
   $
��1146��6#   .@�5�     #   MahApps.Metro.Controls.Flyout   & "MahApps.Brushes.Control.Background#���  6   +   Position$	+ Top=�6`   ,   IsAutoCloseEnabled, . -   AutoCloseInterval$
- 5000��6�   $��45��6�   .   CloseButtonVisibility$. 	Collapsed=�6�   /   IsOpen/ 6�   �� *MostrarMensagem+.��5�     �� $ 
Horizontal=�6   $��Center=�66   $��Center=�6Q   #���  6n   .+�5�       $��Center=�65   $��0 0 10 0q�6R   $* AlertCircle=�6d     MahApps.Brushes.Accent#���  6w   $��20��6�   $��20��6�   �� 5�     $��16(�6    $��Center=�6.   ��6I   �� *ConteudoMensagem+6m   5�     5�     5�     5�     5�     