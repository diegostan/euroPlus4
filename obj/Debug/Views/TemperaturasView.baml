   M S B A M L   `   `   `  ����H  DRife.Keyboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:Rife.Keyboard;assembly=Rife.KeyboardRife.Keyboard  5	       euroPlus4_1(   "euroPlus4_1.Views.TemperaturasView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f;controls,http://metro.mahapps.com/winfx/xaml/controls  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      ^ ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac	 _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af
 bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  	 
                    5      gkbrd2clr-namespace:Rife.Keyboard;assembly=Rife.Keyboard  	 
                    5	        N� Title$  TemperaturasView��5      .��5      � $	��698��6   .+�5   
   �� $��Stretch=�6   $��Stretch=�63   $
��1146��6O   $	��698��6\   .+�5      �� $��45��6   $��Stretch=�6%   $
��1146��6D   $��0 0 0 0q�6Q    J� Opacity$	 0.8Q�6c   .+�5      �� $��10q�6   $��20(�6(    �� TextAlignment$ Center=�66   $��Center=�6M   
�������Temperaturas6�   5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  5      $��0q�62   $	��653��6>   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffects 5      ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5         Kind$ FadeIn=�66      Duration$ 0:0:0.8h�6D   .��5      � $��10q�6   .+�5      4  .MahApps.Metro.Controls.MetroAnimatedTabControl  -   5          Name$
 menu��5   M   -  'MahApps.Metro.Controls.TabControlHelper   
Underlined$ TabPanel=�6[   ��67   Z� .@�5      )  #MahApps.Metro.Controls.MetroTabItem  $��	 ajustes ��60   .��5      �� $	��584��6)   $��10q�66    �� Orientation$ 
Horizontal=�6B   .+�5   "   �� $	��900��6-   .+�5   &   �� $��5q�60   $��20(�6;   $��SemiBold"�6I   
�������Ajustes de temperaturas6�   �� 5    &   $ 
Horizontal=�61   .+�5!   *   ,  &MahApps.Metro.IconPacks.PackIconModern  	   Kind$	 ThermometerCelcius=�6C   $��Center=�6]   $��8q�6z   
�������$��25��6�   $��25��6�   �� 5"   *   $��5q�64   $��Center=�6?   
�������$��18(�6n   $��Medium"�6|   Temperatura do flúido6�   5#   '   *  $MahApps.Metro.Controls.NumericUpDown  5%   &   -   5        $��0 0 0 10q�5%   =   *	  $MahApps.Metro.Controls.TextBoxHelper
 	  SelectAllOnFocus
 . $	��350��6�   $��50��6�      UpDownButtonsWidth$ 50Q�6�      TextAlignment$
 Left=�6�      Minimum$ 0Q�6�   $��26(�69  $��Medium"�6G  $
��Left=�6[     Maximum 6�   �� *#!Temperaturas.MaxTemperaturaFluido+   Value 6  �� * Temperaturas.TemperaturaFluido+6�  �� 5'   &   $ 
Horizontal=�61   .+�5(   *     $��Center=�6C   $��8q�6`   $	 ThermometerHoneywell=�6k   
�������$��25��6�   $��25��6�   �� 5)   *   $��5q�64   $��Center=�6?   
�������$��18(�6n   $��Medium"�6|   Temperatura câmara6�   5*   '     5+   &   -   5        $��0 0 0 30q�5+   =   
 . $	��350��6�   $��50��6�   $ 50Q�6�   $
 Left=�6�   $ 0Q�6�   $��26(�69  $��Medium"�6G  $
��Left=�6[   6�   �� *#!Temperaturas.MaxTemperaturaCamara+ 6  �� * Temperaturas.TemperaturaCamara+6�  �� 5-   &   $ 
Horizontal=�61   .+�5.   *     $��Center=�6C   $��8q�6`   $	 ThermometerDigital=�6k   
�������$��25��6�   $��25��6�   �� 5/   *   $��5q�64   $��Center=�6?   
�������$��18(�6n   $��Medium"�6|   Leituras atuais6�   50   '   �� 52   &   $ 
Horizontal=�61   .+�53   *   �� $	��230��65   .+�54   .   �� $��5q�68   $��Light"�6C   $��18(�6V   
�������Temperatura do flúido:6�   �� 55   .   $��5q�68   $��Light"�6C   $��18(�6V   
�������Temperatura auxiliar flúido:6�   �� 56   .   $��5q�68   $��Light"�6C   $��18(�6V   
�������Temperatura câmara(sup.):6�   �� 57   .   $��5q�68   $��Light"�6C   $��18(�6V   
�������Temperatura câmara(inf.):6�   �� 58   .   $��5q�68   $��Light"�6C   $��18(�6V   
�������Saída de controle flúido:6�   �� 59   .   $��5q�68   $��Light"�6C   $��18(�6V   
�������Saída de controle câmara:6�   5:   +   �� 5;   *   .+�5<   .   �� $��5q�68   $��Medium"�6C   $��18(�6W   
���������6{   �� *'%Temperaturas.LeituraTemperaturaFluido+6�   �� 5=   .   $��5q�68   $��Medium"�6C   $��18(�6W   
���������6{   �� */-Temperaturas.LeituraTemperaturaFluidoAuxiliar+6�   �� 5>   .   $��5q�68   $��Medium"�6C   $��18(�6W   
���������6{   �� */-Temperaturas.LeituraTemperaturaCamaraSuperior+6�   �� 5?   .   $��5q�68   $��Medium"�6C   $��18(�6W   
���������6{   �� */-Temperaturas.LeituraTemperaturaCamaraInferior+6�   �� 5@   .   $��5q�68   $��Medium"�6C   $��18(�6W   
���������6{   �� *" Temperaturas.SaidaControleFluido+6�   �� 5A   .   $��5q�68   $��Medium"�6C   $��18(�6W   
���������6{   �� *" Temperaturas.SaidaControleCamara+6�   5B   +   5C   '   �� 5H   &   $ 
Horizontal=�61   $��0 20 0 0q�6J   $��Center=�6\   .+�5J   *   �� $	��0.1q�61   $
��auto��6G   $��16(�6V   $��Medium"�6d   $	��350��6x   $
��Left=�6�   $��0 0 0 0q�6�   $
 0.66Q�6�    ,  (MahApps.Styles.Button.MetroSquare.Accent#���   6�   
���������6  �� *EnviarValoresAjuste+��5K   .   �� 5L   2   $ 
Horizontal=�6=   $��0q�6V   .+�5M   6     $��Center=�6O   $��8q�6l   $	 CheckmarkPencil=�6w   
�������$��25��6�   $��25��6�   �� 5N   6   $��5q�6@   $��Center=�6K   Aplicar valores6w   5O   3   5Q   +   5R   '   5T   #   �� 5V   "   $	��206��6-   .+�5W   &   �� $��5q�61   $ 
Horizontal=�6<   $
��Left=�6U   .+�5X   *   '
  !MaterialDesignThemes.Wpf.PackIcon
   
  Kind$ TemperatureCelsius=�6B   $��20��6\   $��20��6h   
�������$��Center=�6�   �� 5Y   *   $��5q�64   $��Medium"�6?   $��12(�6S   
�������$��Center=�6t   Controle de temperatura6�   5Z   '   �� 5[   &   $
 Left=�60   $��5q�6E   $��Light"�6P   $��11(�6c   
�������$
��Wrap=�6�   ECDefina o valor desejado para as zonas de temperaturas específicas.6�   �� 5]   &   $��	5 20 0 0 q�61   $ 
Horizontal=�6D   $
��Left=�6]   .+�5^   *   
  $ ViewDashboard=�6B   $��20��6W   $��20��6c   
�������$��Center=�6�   �� 5_   *   $��5q�64   $��Medium"�6?   $��12(�6S   
�������$��Center=�6t   	Dashboard6�   5`   '   �� 5a   &   $
 Left=�60   $��5q�6E   $��Light"�6P   $��11(�6c   
�������$
��Wrap=�6�   JHApresente os dados de temperaturas entre outros na tela de visão geral.6�   5c   #   5e      5f        5h      $�� tolerâncias ��60   .��5i      �� $	��584��6)   $��10q�66   $ 
Horizontal=�6B   .+�5j   "   �� $	��900��6-   .+�5k   &   �� $��5q�60   $��20(�6;   $��SemiBold"�6I   
�������Controle de tolerâncias6�   �� 5l   &   $ 
Horizontal=�61   .+�5m   *     $��Center=�6C   $��8q�6`   $	 GraphLineUp=�6k   
�������$��25��6�   $��25��6�   �� 5n   *   $��5q�64   $��Center=�6?   
�������$��18(�6n   $��Medium"�6|   Valores máximos6�   5o   '   �� 5p   &   $��5q�60   $��Light"�6;   $��16(�6N   
�������Temperatura flúido (ºC)6�     5q   &   -   5        $��0 0 0 10q�5q   =   
 . $	��350��6�   $��50��6�   $ 50Q�6�   $
 Left=�6�   $ 0Q�6�   $
 1000Q�6�   $��26(�6  $��Medium"�6"  $
��Left=�66   6�   �� *#!Temperaturas.MaxTemperaturaFluido+6�  �� 5s   &   $��5q�60   $��Light"�6;   $��16(�6N   
�������Temperatura da câmara (°C)6�     5t   &   -   5        $��0 0 0 10q�5t   =   
 . $	��350��6�   $��50��6�   $ 50Q�6�   $
 Left=�6�   $ 0Q�6�   $
 1000Q�6�   $��26(�6  $��Medium"�6"  $
��Left=�66   6�   �� *#!Temperaturas.MaxTemperaturaCamara+6�  �� 5v   &   $ 
Horizontal=�61   .+�5w   *     $��Center=�6C   $��8q�6`   $	 GraphLineDown=�6k   
�������$��25��6�   $��25��6�   �� 5x   *   $��5q�64   $��Center=�6?   
�������$��18(�6n   $��Medium"�6|   Valores mínimos6�   5y   '   �� 5z   &   $��5q�60   $��Light"�6;   $��16(�6N   
�������Temperatura flúido (°C)6�     5{   &   -   5        $��0 0 0 10q�5{   =   
 . $	��350��6�   $��50��6�   $ 50Q�6�   $
 Left=�6�   $ 0Q�6�   $
 1000Q�6�   $��26(�6  $��Medium"�6"  $
��Left=�66   6�   �� *#!Temperaturas.MinTemperaturaFluido+6�  �� 5|   &   $��5q�60   $��Light"�6;   $��16(�6N   
�������Temperatura da câmara (°C)6�     5}   &   -   5        $��0 0 0 10q�5}   =   
 . $	��350��6�   $��50��6�   $ 50Q�6�   $
 Left=�6�   $ 0Q�6�   $
 1000Q�6�   $��26(�6  $��Medium"�6"  $
��Left=�66   6�   �� *#!Temperaturas.MinTemperaturaCamara+6�  �� 5�   &   $ 
Horizontal=�61   $��0 20 0 0q�6J   $��Center=�6\   .+�5�   *   �� $	��0.1q�61   $
��auto��6G   $��16(�6V   $��Medium"�6d   $	��350��6x   $
��Left=�6�   $��0 0 0 0q�6�   $
 0.66Q�6�   #���   6�   
���������6  �� *EnviarValoresTolerancia+��5�   .   �� 5�   2   $ 
Horizontal=�6=   $��0q�6V   .+�5�   6     $��Center=�6O   $��8q�6l   $	 CheckmarkPencil=�6w   
�������$��25��6�   $��25��6�   �� 5�   6   $��5q�6@   $��Center=�6K   Aplicar valores6w   5�   3   5�   +   5�   '   5�   #   �� 5�   "   $	��206��6-   .+�5�   &   �� $��5q�61   $ 
Horizontal=�6<   $
��Left=�6U   .+�5�   *   -  'MahApps.Metro.IconPacks.PackIconUnicons  $��Center=�6D   $��Center=�6a   $��0q�6|      Kind$ ArrowsShrinkV=�6�   
�������$��20��6�   $��20��6�   �� 5�   *   $��5q�64   $��Medium"�6?   $��12(�6S   
�������$��Center=�6t   Configurar tolerâncias6�   5�   '   �� 5�   &   $
 Left=�60   $��5q�6E   $��Light"�6P   $��11(�6c   
�������$
��Wrap=�6�   ��Os valores de tolerância permitem que o sistema gerencie o espectro das variáveis controladas no sistema de temperatura além de gerar alarmes caso os valores reais ultrapassem essas tolerâncias.6\  5�   #   5�      5�        5�      $�� configurações ��60   .��5�      �� $��0,0,-10, -10q�6+   $
��Auto=�6B   $
��auto��6e   ��. .��5�      �� $	��584��6)   $��10q�66   $ 
Horizontal=�6B   .+�5�   "   �� $	��900��6-   .+�5�   &   �� $��5q�60   $��20(�6;   $��SemiBold"�6I   
�������Configuração de parâmetros6�   �� 5�   &   $ 
Horizontal=�61   .+�5�   *   .  (MahApps.Metro.IconPacks.PackIconMaterial  $��Center=�6E   $��8q�6b      Kind$ ThermometerMinus=�6m   
�������$��25��6�   $��25��6�   �� 5�   *   $��5q�64   $��Center=�6?   
�������$��18(�6n   $��Medium"�6|   Ajustar offset6�   5�   '   �� 5�   &   $��5q�60   $��Light"�6;   $��16(�6N   
�������(&Offset de temperatura do flúido (°C)6�     5�   *   -   5        $��0 0 0 10q�5�   A   
 . $	��350��6�   $��50��6�   $ 50Q�6�   $
 Left=�6�   $ 0Q�6�   $	 100Q�6�   $��26(�6  $��Medium"�6(  $
��Left=�6<   6�   �� *&$Temperaturas.OffSetTemperaturaFluido+6�  �� 5�   &   $��5q�60   $��Light"�6;   $��16(�6N   
�������(&Offset de temperatura da câmara (°C)6�     5�   *   -	   5        $��0 0 0 30q�5�   A   
 . $	��350��6�   $��50��6�   $ 50Q�6�   $
 Left=�6�   $ 0Q�6�   $	 100Q�6�   $��26(�6  $��Medium"�6(  $
��Left=�6<   6�   �� *&$Temperaturas.OffSetTemperaturaCamara+6�  �� 5�   &   $ 
Horizontal=�61   .+�5�   *     $��Center=�6E   $��8q�6b   $ ThermometerLines=�6m   
�������$��25��6�   $��25��6�   �� 5�   *   $��5q�64   $��Center=�6?   
�������$��18(�6n   $��Medium"�6|   Controle de proporcionalidade6�   5�   '   �� 5�   &   $��5q�60   $��Light"�6;   $��16(�6N   
�������)'Percentual de coeficiênte integral (%)6�     5�   *   -
   5        $��0 0 0 10q�5�   A   
 . $	��350��6�   $��50��6�   $ 50Q�6�   $
 Left=�6�   $ 0Q�6�   $	 100Q�6�   $��26(�6   $��Medium"�6.  $
��Left=�6B   6�   �� *,*Temperaturas.PercentualCoeficienteIntegral+6�  �� 5�   &   $��5q�60   $��Light"�6;   $��16(�6N   
�������Números de amostras (uni.)6�     5�   *   -   5        $��0 0 0 10q�5�   A   
 . $	��350��6�   $��50��6�   $ 50Q�6�   $
 Left=�6�   $ 0Q�6�   $	 100Q�6�   $��26(�6  $��Medium"�6  $
��Left=�63   6�   �� *Temperaturas.NumeroAmostras+6�  �� 5�   &   $��5q�60   $��Light"�6;   $��16(�6N   
�������)'Intervalo de cada amostra (milisegundo)6�     5�   *   -   5        $��0 0 0 10q�5�   A   
 . $	��350��6�   $��50��6�   $ 50Q�6�   $
 Left=�6�   $ 0Q�6�   $	 100Q�6�   $��26(�6  $��Medium"�6"  $
��Left=�66   6�   �� * Temperaturas.IntervaloAmostras+6�  �� 5�   &   $ 
Horizontal=�61   $��	0 20 0 20q�6J   $��Center=�6]   .+�5�   .   �� $	��0.1q�65   $
��auto��6K   $��16(�6Z   $��Medium"�6h   $	��350��6|   $
��Left=�6�   $��0 0 0 0q�6�   $
 0.66Q�6�   #���   6�   
���������6  �� *EnviarValoresConfiguracao+��5�   .   �� 5�   2   $ 
Horizontal=�6=   $��0q�6V   .+�5�   6     $��Center=�6O   $��8q�6l   $	 CheckmarkPencil=�6w   
�������$��25��6�   $��25��6�   �� 5�   6   $��5q�6@   $��Center=�6K   Aplicar valores6w   5�   3   5�   +   5�   '   5�   #   �� 5�   "   $	��206��6-   .+�5�   &   �� $��5q�61   $ 
Horizontal=�6<   $
��Left=�6U   .+�5�   *   .  (MahApps.Metro.IconPacks.PackIconEvaIcons  $��Center=�6E   $��Center=�6b   $��0q�6}      Kind$ ThermometerMinusOutline=�6�   
�������$��20��6�   $��20��6�   �� 5�   *   $��5q�64   $��Medium"�6?   $��12(�6S   
�������$��Center=�6t   Ajuste de offset6�   5�   '   �� 5�   &   $
 Left=�60   $��5q�6E   $��Light"�6P   $��11(�6c   
�������$
��Wrap=�6�   ��Quando o controlador apresenta valores residuais ou algum tipo de ruído com o sensor desconectado(você desconecta o sensor e o valor não desce para 0) então é necessário ajustar o offset que compensa essa perda melhorando a precisão do sistema.6�  �� 5�   &   $��5q�61   $ 
Horizontal=�6<   $
��Left=�6U   .+�5�   *     $��Center=�6E   $��Center=�6b   $��0q�6}   $ WaterPercent=�6�   
�������$��20��6�   $��20��6�   �� 5�   *   $��5q�64   $��Medium"�6?   $��12(�6S   
�������$��Center=�6t   Proporcionalidade6�   5�   '   �� 5�   &   $
 Left=�60   $��5q�6E   $��Light"�6P   $��11(�6c   
�������$
��Wrap=�6�   ��O sistema de controle da temperatura e realizado por diversos calculos que prevê e atua em possíveis correções de valores futuros do sistema, também é possível configurar o coeficiente integral para que o sistema compense a inércia térmica gerados pelos valores de condutividade e difusividade térmica do flúido.6�  �� 5�   &   $��5q�61   $ 
Horizontal=�6<   $
��Left=�6U   .+�5�   *   0  *MahApps.Metro.IconPacks.PackIconRPGAwesome  $��Center=�6G   $��Center=�6d   $��0q�6      Kind$
 Vial=�6�   
�������$��20��6�   $��20��6�   �� 5�   *   $��5q�64   $��Medium"�6?   $��12(�6S   
�������$��Center=�6t   
Amostras6�   5�   '   �� 5�   &   $
 Left=�60   $��5q�6E   $��Light"�6P   $��11(�6c   
�������$
��Wrap=�6�   ��Para manter uma leitura e um valor de controle estável é necessário que o sistema gere coletas de amostras para criar uma média entre todas, o número de amostras define a quantidade de amostras que o sistema deve coletar para gerar a média e o intervalo de cada amostra é o tempo que cada valor será coletado. Atenção especial a esses parâmetros pois a estabilidade do sistema é inversamente proporcional à resposta de leitura, quanto maior o número de amostra e mais longo o intervalo, maior será a precisão, no oposto disso teremos uma leitura mais rapida e menor precisão.6�  5�   #   5�      5�      5�      5�      5�      5�      5�      +  %MahApps.Metro.Controls.FlyoutsControl  5�   
   $
��1146��6#   .@�5�      #  MahApps.Metro.Controls.Flyout     Position$	 Top=�6      IsAutoCloseEnabled .    AutoCloseInterval$
 3000��6G   $��45��6`      CloseButtonVisibility$ 	Collapsed=�6�      IsOpen 6m   �� *MostrarMensagem+.��5�      �� $ 
Horizontal=�6   $��Center=�66   $��Center=�6Q   .+�5�      2  ,MahApps.Metro.IconPacks.PackIconFeatherIcons  $��Center=�65   $��0 0 10 0q�6R      Kind$ CheckCircle=�6d     MahApps.Brushes.Accent#���  6w   $��20��6�   $��20��6�   �� 5�      $��16(�6    $��Center=�6.   ��6I   �� *ConteudoMensagem+6m   5�      5�      5�      5�      5�      