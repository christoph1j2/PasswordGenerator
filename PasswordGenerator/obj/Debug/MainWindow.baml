   M S B A M L   `   `   `  ����L  HPasswordGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PasswordGeneratorPasswordGenerator  5   	   "    PasswordGenerator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:PasswordGenerator     5   	     � Title$  Password Generator��5   	   $	��450��6$   $	��800��61   .��5	      �� .+�5
   
   �� -   5         ��Name$ capitalIndicator��5
      ���#ff0000$��34��6=    �� Left$ 98��6I   
������ 
 �� Top$ 98��6o   $	��104��6   �� 5   
   -   5        $ lowercaseIndicator��5      ���#ff0000$��34��6?   $	 268��6K   
������ $ 98��6r   $	��104��6�   �� 5   
   -   5        $ numberIndicator��5      ���#ff0000$��34��6<    �� Right$ 98��6H   
������ $ 98��6o   $	��104��6   �� 5   
   -   5        $ specialIndicator��5      ���#ff0000$��34��6=   $	 268��6I   
������ $ 98��6q   $	��104��6�   �� 5   
   -   5         ��Name$ CapitalLetters��5      $��Capital Letters��6)   $��30��6C   $	��100��6O   $	 100��6[   $	 100��6m   6�   �� 5   
   -   5        $ 	LowerCase��5      $��Lowercase Letters��6$   $��30��6@   $	��100��6L   $	 270��6X   $	 100��6j   6�   �� 5   
   -   5        $ SpecialChars��5      $��Special Characters��6'   $��30��6D   $	��100��6P   $	 270��6\   $	 100��6o   6�   �� 5   
   -   5        $ Numbers��5      $��Numbers��6"   $��30��64   $	��100��6@   $	 100��6L   $	 100��6_   6�   �� 5   
   -	   5         ��Name$ Length��5      $��20��6"    �� TextAlignment$ Center=�6.    �� TextWrapping$
 Wrap=�6F   $�� ��6Z   $��50��6b   $	 375��6m   $	 175��6   �� 5   
   $��Length:��6   $	 375��6"   $	 150��64   �� 5   
   -
   5        $ output��5      $��40��6#   $
 Wrap=�6/   $�� ��6C   $	��254��6K   $	 270��6W   $	 255��6i   �� 5   
   -   5        $��Generate��5      $��85��6$   $	 361��6/   $	 300��6A   $��25��6R   6^   �� 5   
   -   5        $��Save Password��5      $	 694��6)   $	 391��6;   $��90��6L   6W   �� 5   
   -   5        	 ��Name$		 err��5      $	 694��6"   $
��Wrap=�64   $�� ��6H   $	 356��6P   $��30��6a   $��90��6m   5      5      