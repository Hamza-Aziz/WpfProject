   M S B A M L   `   `   `  ����C  ?WpfApp16, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp16WpfApp16  5          WpfApp16.UserControl3   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:WpfApp16     5      k gTelerik.Windows.Controls.Data, Version=2019.3.1023.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7l hTelerik.Windows.Controls.Input, Version=2019.3.1023.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7o kTelerik.Windows.Controls.GridView, Version=2019.3.1023.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7b ^Telerik.Windows.Data, Version=2019.3.1023.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7f	 bTelerik.Windows.Controls, Version=2019.3.1023.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q
 mTelerik.Windows.Controls.Navigation, Version=2019.3.1023.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Itelerik1http://schemas.telerik.com/2008/xaml/presentation     	 
 5      .��5      � .+�5   
   �� $��Rechercher par filiere��6   $
��Left=�61   $��	20,70,0,0q�6L   $	��Top=�6_   $��35��6w   $	��205��6�   $��Times New Roman)�6�   $
��Bold"�6�   $��18(�6�   �� 5   
   -   5          ��Name$  Combobox��5      $
��Left=�6%   $��
25,100,0,0q�6@   $	��Top=�6T   $	��230��6l   $��35��6x   $��0q�6�   
�������6�   � 5   
   $
��Left=�6   $	��200��6*   $��
20,160,0,0q�67   $	��Top=�6K   $	��250��6c   ���	#FF23E1EA.+�5      �� $$��Informations sur la filiere  :��6   $
��Left=�6=   $��30��6X   $��
0,10,-30,0q�6d   $	��Top=�6x   $	��280��6�   $��Rockwell Extra Bold)�6�   $��14(�6�   $
��Bold"�6�   �� 5      $��Responsable :��6   $
��Left=�6,   $��
10,130,0,0q�6G   $	��Top=�6[   $	��135��6s   $��Rockwell Extra Bold)�6   $��14(�6�   �� 5      -   5         ��Name$ 	Mafiliere��5       $�� ��6   $
��Left=�63   $��23��6N   $��	45,45,0,0q�6Z   $	��Top=�6n   $	��120��6�   $��Segoe UI Black)�6�   $��14(�6�   $��0q�6�   ��6�   Z� �� 5      -   5        $ ChefFiliere��5   !   $�� ��6   $
��Left=�66   $��28��6Q   $��150,130,0,0q�6]   $	��Top=�6s   $��90��6�   $��0q�6�   ��6�   Z� 6�   5      �� 5   
   -   5        $ label1��5   y   $�� ��6   $
��Left=�6   $��34��66   $��	85,16,0,0q�6B   $	��Top=�6U   $	��645��6m   
���   ����	#FF23E1EA$
��Bold"�6�   $��Rockwell Extra Bold)�6�   $��16(�6�   ���	#FF855C5C J� RenderTransformOrigin$ 0.871,-0.618&�6  �� 5   
   -   5        $��Modifier��5      $
��Left=�6$   $��505,385,0,0q�6?   $	��Top=�6T   $	��120��6l   $��40��6x   $ 0.542,-0.25&�6�   $��Rockwell Extra Bold)�6�   $
��Bold"�6�   $��16(�6�   ���	#FF17EAFF6  *  $Telerik.Windows.Controls.RadGridView  5   
   -   5        $��RadGridV��5      $
��Left=�6.   $��310,100,0,0q�6I   $	��Top=�6^   $	��260��6v   $	��420��6�   ���	#FF23E1EA;  5Telerik.Windows.Controls.GridView.GridViewDataControl   Columns 5    
   -  'Telerik.Windows.Controls.GridViewColumn  5!         Header$	 CNE��6%      CellTemplate 5"      �� 5#      .R�5$      �� ��6$   �� *cne+5%      5'        5(      $	 Nom��6%    5)      �� 5*      .R�5+      �� ��6$   �� *nom+5,      5.        50      $ Prenom��6%    51      �� 52      .R�53      �� ��6$   �� *prenom+54      56        57      $ Date de Naissance��6%    58      �� 59      .R�5:      �� ��6$   �� *	dateNaiss+5;      5=        5?      $ photo��6%    5@      �� 5A      5C      5E      5G      5J      5K      