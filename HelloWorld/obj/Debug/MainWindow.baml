   M S B A M L   `   `   `  ����E  AHelloWorld, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:HelloWorld
HelloWorld  5   	       HelloWorld.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:HelloWorld     5   	     � Title$  
MainWindow��5   	   $��303.444��6   $��494.132��6-   .��5	      �  J� RenderTransformOrigin$ 0.484,0.741&�6   .+�5
   
   �� -   5         ��Name$ uxContainer��5
      .+�5      �� -   5         ��Name$ uxList��5       �� View 5      �� 5      .P�5      �� $��	User Name��6S    �� Width$	 100��6f    �� DisplayMemberBinding 6)   �� *
UserName+6f   �� 5      $��Password��6W   $	 100��6i    6)   �� *UserPassword+6i   5      5      �� 5      Enter Name:6%   �� 5      -   5         ��Name$ uxName��5      $
��Bold"�6�   $��18(�6�   ���	#FFE1F5FF��6&   �� *BindingGroupName+ �� UpdateSourceTrigger$ PropertyChanged=�	 �� ValidatesOnDataErrors	 . 6�   �� 5      Enter Password:6)   G� 5      -   5        
 G�Name$
 
uxPassword��5      ���	#FFE8F7D3$��0,0,0,10q�6E   5      �� 5      -   5         ��Name$ uxSubmit��5       � Cursor$
 Hand��6o    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ 	#FF3C3C3C��6'   .��5   !   Submit6*   5      5      5      