   M S B A M L   `   `   `  ����C  ?TestMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:TestMVVMTestMVVM  5   	       TestMVVM.View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:TestMVVM     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	   	   b ^GalaSoft.MvvmLight.Platform, Version=5.4.1.0, Culture=neutral, PublicKeyToken=5f873c45e98af8a1.command http://www.galasoft.ch/mvvmlight  5
   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5   	   �� *MainViewModel+   Locator �� Source# [  .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      /  )GalaSoft.MvvmLight.Command.EventToCommand     Command 6%   �� *LoadedCommand+ �� Mode$ OneWay=�5      .��5      � 	 � RowDefinitions	 5   
   �� 5      $��60 �6   6*   �� 5      $��* �6   6)   �� 5      $��45 �6   6*   .+�5   
   �� $��0��6   
 �� Orientation$
 
Horizontal=�6"   .+�5      �� $��20(�6/   $��	15,0,15,0q�5      $
��Left=�6'   $��Center=�6B   ��5      �� *Header+5   B   �� 5      -   5        $��	PageTitle��5      $��Center=�6L   $��20(�6g   ��6%   �� *Title+$ TwoWay=�6g   5      �� 5    
   -   5        $��ButtonLogout��5       $��0��6   $��LOG OUT��6T   $��0,0,15,0q�6g   $��20(�5!      
�������
�������
�������$��Right=�5"      $��Center=�6.   ��5    2   �� *LogoutCommand+5"   .   �� 5#   
   $��0��6   $��Bottom=�6!   � 5&   
   $��1��6   .+�5'       � -   5          �Name$ 	MainFrame��5(      $��Stretch=�5)      $��Stretch=�5*        � NavigationUIVisibility$ Hidden=�5+      5,      � 5/   
   $��2��6   .+�50      �� .+�51      �� $��0��6   ���#FFD10A$��5��6:   $��0,0,0,0q�6E   �� 52      $��0��6   $��40��6%   $��0,0,0,0q�61   ��6B   �� *Footer+53      54      55      56      