   M S B A M L   `   `   `  ����F  BFinalReview, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:FinalReviewFinalReview  5   	       FinalReview.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:FinalReview     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��600��6)    J� CommandBindings 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5           Command$	 New��5
      6^   .��5      �� .+�5   
   o� .@�5      m� $��_File��6   .@�5      m� -   5        $
��_New��5      6)   m� 5      $��_Open��6   �� 5      m� 5      -   5        $��E_xit��5      6*   5      m� 5      $��_Edit��6   m� 5      $��_Help��6   5      �� 5   
   $��Click Me��6    � ContextMenu 5      �� 5      .@�5      m� $��Menu item 1��6   m� 5      $��Menu item 2��6   �� 5      m� 5      $��Menu item 3��6   5      5       �� 5!   
   -   5         ��Name$ uxNameError��5!      $��30��6h   ��6%   �� *	NameError+ �� UpdateSourceTrigger$ PropertyChanged=�6v   �� 5"   
   $��0,10,0,0q�6   
Enter Name62   �� 5#   
   -   5         ��Name$ uxName��5#   j   $��0,10,0,0q�6z   ��6   �� *Name+$ PropertyChanged=� �� ValidatesOnDataErrors . 6�   �� 5$   
   $��0,10,0,0q�6   Enter Password66   G� 5%   
   -   5         G�Name$ 
uxPassword��5%      $��0,10,0,0q�6*   6?   �� 5&   
   Age6   �� 5'   
   6   ]� 5(   
   .+�5)      �� -   5        	 ��Name$	 uxShowPassword��5)      $��Center=�6/   $��Center=�6J   .��6g   Show Password6v   5*      �� 5+   
   -   5        
 ��Name$
 uxSubmit��5+       � Cursor$
 Hand��6:    � ToolTip$# Click here to submit password��6H   ���	#FFD6B1B1$
��Bold"�6�   $��14(�6�   $	��Top=�6�   $��0,10,0,0q�6�   .��6�   Submit6�   �� 5,   
   $=��7C:\source\ccsharp-client\FinalReview\Images\Bertha3.jpg��6   $	��200��6Q   $��Center=�6]   $��0,10,0,0q�6x   $��Center=�6�   ]� 5-   
   .+�5.      �� -	   5        $	 uxSTPWorker��5.      $��0,0,10,0q�6,   .��6>   
STP Worker6J   �� 5/      -
   5        $	 uxGuest��5/      .��6(   Guest6/   50      51      52      