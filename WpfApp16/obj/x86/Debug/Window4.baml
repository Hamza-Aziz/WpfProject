   M S B A M L   `   `   `  ����C  ?WpfApp16, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp16WpfApp16  5   	       WpfApp16.Window4   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp16     5   	     � Title$  Window4��5	   	   $	��500��6   $	��350��6&    � 
ResizeMode$ NoResize=�62    � WindowStartupLocation$ CenterScreen=�6H    � WindowStyle$
 None=�6m   .��5
      � .+�5   
   �� $	��280��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF2281D1��6#   � 5      $ 	#FF34268A��6#    � Offset$ 1Q�65   � 5      $ 	#FF33288B��6#   $	 0.5Q�65   5      5      �� 5   
   $��Assets/logo.png��6   $	��100��6)   $	��100��65   $	��Top=�6B   $��20q�6Z   �� 5   
   $	��280��6   $	��240��6    
�������$��Bottom=�6:   $��0,100q�6U    �� RadiusY$ 40��6d   	 �� RadiusX$	 40��6q   
 J� Effect
 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ 	#FFBBBBBB��6#      	Direction$ 0Q�65      
BlurRadius$ 15Q�6C      RenderingBias$ Quality=�6S      ShadowDepth$ 1Q�6k   5      � 5   
   $	��240��6   $	��280��6   $��Bottom=�6(   $��0,100q�6C   .+�5      �� $��lOGIN��6   $	��Top=�6%   $��Center=�6=   $��5q�6Z   
�������$��18(�6w   �� 5      $��Center=�6   $��10q�64   .+�5      �� -   5        $��login��5   G   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Utilisateur��6    %  !MaterialDesignFloatingHintTextBox#��[  6T   $
��0,10q�6�   $��Cambria Math)�6�   $��18(�6�   G� 5      -   5        $	��mdp��5   L   $ Mot de passe��6    ) %MaterialDesignFloatingHintPasswordBox#��[ 6W   $��Cambria Math)�6�   $��18(�6�   $
��0,10q�6�   5       5!      �� 5"   
   -   5        $��Bottom=�5"      $
��0,85q�6,   $	��150��6:   $��Login��6F   6V   �� 5#   
   $ ��votre mot de passe oubliee��6   $��Center=�66   $��Bottom=�6S   $��50q�6n   5$      5%      