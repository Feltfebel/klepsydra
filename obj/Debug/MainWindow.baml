   M S B A M L   `   `   `  ����D  @klepsydra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:klepsydra	klepsydra  5   	       klepsydra.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:klepsydra     5   	   -   5          �Name$  KlepsydraWindow��5   	    � Title$ 
Klepsydra ��5   	   $	��290��6   $	��800��6)    � 
ResizeMode$ NoResize=�6P   $��1q�6f   $��0q�6q   
�������.��5
      � .+�5   
   �� -   5         ��Name$ brdProgress��5      
�������$��Center=�6=   
�������$��1q�6s   $	��800��6�   $��3q�6�   ._�5      �� .+�5      �� -   5         ��Name$ 	sldMinuty��5       �� IsSnapToTickEnabled . $��5q�6n    � Minimum$ 1Q�6y    � Maximum$ 5Q�6�    �� TickPlacement$ BottomRight=�6�   	 �� TickFrequency$	 1Q�6�   $	��500��6�   �� 5      -   5        
 ��Name$
 sldText��5      $��5q�6,   $��50��67   ��6B   ��  �� ElementName$ 	sldMinuty�� �� Path$ Value� �� UpdateSourceTrigger$ PropertyChanged=�� 5      $��5q�6   .+�5      � -   5         �Name$ Postep��5   "   $ 1Q�62   $ 60Q�6>   $	��120��6K   $��5,5,5.223,4.556q�6X   $��2��6q   �� 5      -   5         ��Name$ 	txtPostep��5       $��Center=�63   $��32(�6P   $
��Bold"�6^   $��Center=�6p   $��394,44,270.667,42.556q�6�   5      � 5      $��5q�6   .+�5      �� -   5         ��Name$ btnClose��5      $��Z a m k n i j��6/   $��Right=�6G   $��5q�6c   $��25��6�   $	��100��6�   $
��Bold"�6�   �� 5      -   5        $ 
btnRestart��5      $��R e s t a r t��61   $
��Left=�6I   $��5q�6d   $��25��6�   $	��100��6�   $
��Bold"�6�   �� 5      -	   5        $ 	btnCancel��5      $��S t o p��60   $��Center=�6B   $��25��6w   $	��100��6�   $
��Bold"�6�   5      5      5      5      5      