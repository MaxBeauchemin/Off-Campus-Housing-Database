   M S B A M L   `   `   `  ����  OffCampusHousingDatabase)    #OffCampusHousingDatabase.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Rent Oshkosh��5   	   $	��450��6   $	��800��6+   
������� � WindowStyle$ ThreeDBorderWindow=�6J    � 
ResizeMode$ NoResize=�6k    � WindowStartupLocation$ CenterScreen=�6�   .��5      � $
��Left=�6   $	��450��6&   $	��800��63   $��0,0,0,0q�6?   $	��Top=�6P   .+�5   
   �� ���	#FF90BCFD$
��Left=�6%   $��46��6@   
���   �$	��Top=�6[   $	��818��6s   $��	-18,0,0,0q�6   �� 5   
   -   5         ��Name$ LoginTextblock��5      $
��Left=�6,   $��
624,13,0,0q�6G   $
��Wrap=�6[   $��Login��6o   $	��Top=�6|   
����  � � Cursor$
 Hand��6�   $��Normal$�6  �� 5	   
   -   5        $ SignupTextblock��5	      $
��Left=�6-   $��
718,13,0,0q�6H   $
��Wrap=�6\   $��Sign up��6p   $	��Top=�6   
����  �$
 Hand��6  $��Normal$�6  �� 5
   
   -   5        $ OrTextblock��5
      $
��Left=�6)   $��
683,13,0,0q�6D   $
��Wrap=�6X   $��or��6l   $	��Top=�6v   �� 5   
   -   5         ��Name$ PropertyListView��5      $
��Left=�6-   $	��294��6H   $��
10,112,0,0q�6U   $	��Top=�6i   $	��576��6�    �� View 5      �� 5      .P�5      �� $��Address��6%    �� Width$	 150��6\   	 �� DisplayMemberBinding	 66   �� *Addr+6\   �� 5      $��Monthly Rent��6%   $	 100��6a   	 6;   �� *Rent+6a   �� 5      $��	Real Data��6%   $	 100��6b   	 68   �� *
RealData+6b   5      5      �� 5   
   $��Filters��6   $
��Left=�6"   $��668,127,0,0q�6=   $	��Top=�6R   �� 5   
   $��Rent Less Than ��6   $
��Left=�6*   $��617,176,0,0q�6E   $	��Top=�6Z   �� 5   
   -   5        
 ��Name$
 FilterRentTextbox��5      $
��Left=�6-   $��23��6H   $��709,179,0,0q�6T    �� TextWrapping$
 Wrap=�6i   $�� ��6}   $	��Top=�6�   $��67��6�   �� 5   
   -   5         ��Name$ FilterButton��5      $��Filter��6(   $
��Left=�69   $��652,251,0,0q�6T   $	��Top=�6i   $��75��6�   6�   5      5      