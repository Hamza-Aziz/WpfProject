   M S B A M L   `   `   `  ����C  ?WpfApp16, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp16WpfApp16  5   	       WpfApp16.ModifierEtudiant   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp16     5   	   k gTelerik.Windows.Controls.Data, Version=2019.3.1023.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7l hTelerik.Windows.Controls.Input, Version=2019.3.1023.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7o kTelerik.Windows.Controls.GridView, Version=2019.3.1023.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7b ^Telerik.Windows.Data, Version=2019.3.1023.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7f	 bTelerik.Windows.Controls, Version=2019.3.1023.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q
 mTelerik.Windows.Controls.Navigation, Version=2019.3.1023.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Itelerik1http://schemas.telerik.com/2008/xaml/presentation     	 
 5   	     � Title$  ModifierEtudiant��5	   	   $��345.324��6"   $	��693��63   .��5
      � ���	#FFA2EEF1$	��312��6"   $	��Top=�6/    � ColumnDefinitions 5   
   �� 5      $��0* �6   �� 5      $	��19* �6   �� 5      $
��273* �6    � RowDefinitions 5   
   �� 5      $	��19* �6   �� 5      $
��230* �6   �� 5      $	��63* �6    � 	Resources 5   
      
MyTemplate0  *Telerik.Windows.Controls.DataFormDataField   Label   DataMemberBinding �� Mode��%�  &	        �� 5      .R�5      �  5      �� 5       5      �� 5      �� 5      �� 5      �� 5       .+�5"        $ CNE :��60    6>   �� *cne+$ TwoWay=�  5#      $��1��60   $ Nom :��6=    6K   �� *nom+$ TwoWay=�  5$      $��2��60   $ Prenom :��6=    6N   �� *prenom+$ TwoWay=�  5%      $��3��60   $ Date_Naissance :��6=    6V   �� *	dateNaiss+$ TwoWay=�5'      5(      5*      .+�5+   
   *  $Telerik.Windows.Controls.RadDataForm  -   5        $��Dataform��5+   �      EditTemplate# [  6      NewItemTemplate# [  6I   	   ReadOnlyTemplate#	 [  6w   
   AutoGenerateFields
 .     
AutoCommit .  $
��Left=�6�   $	��370��6  $��
25,64,0,37q�6  $��2��6"  $��1��62  $��2��6?  6P  �� 5,   
   $��Modifier les étudiants��6   $
��Left=�62   $	��Top=�6M   $��68��6e   $��35,5,0,0q�6q   $	��565��6�   $��2��6�   ���	#FFEA1B1B
���   �$��2��6�   $
��Bold"�6�   $��36(�6�   $��Rockwell Extra Bold)�6�   $��Italic$�6  �� 5-   
   -   5        $��ajouter��5-      
�������$
��Left=�6=   $	��Top=�6X   $	��154��6p   $��2��6|   $��
425,96,0,0q�6�   $��1��6�   $��35��6�   $
��Bold"�6�   5.      �� 5/   
   -   5        $��Modifier��5/      
�������$
��Left=�6>   $	��Top=�6Y   $	��158��6q   $��2��6}   $��425,171,0,0q�6�   $��1��6�   $��35��6�   ���	#FF853737$
��Bold"�6�   51      53      54      