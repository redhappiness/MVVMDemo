   M S B A M L   `   `   `  ����C  ?TestMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:TestMVVM.ViewTestMVVM.View  5          TestMVVM.View.LoginView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:TestMVVM.View     5        � DataContext  5      �� *LoginViewModel+   Locator �� Source# [  .��5
      � -   5         �Name$ 
LoginLayer��5
      
�������.+�5   
   � $��Center=�6   $��Center=�6,   
������� � ColumnDefinitions 5      �� 5      $	��60* �6#   �� 5      $
��100* �6#   �� 5      $��1800* �6#    � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      .+�5      �� $��2��62   $
��Bold"�6F   $��Center=�6X   $��
50,10,60,5q�5   (   $��38(�6<   $��1��6J   ��5      �� *
SomeText+5   J   �� 5      $
��Name��6   $��1��6$   $��	3,4,3,1.6q�61   $��13(�6D   $��2��6R   �� 5      -   5         ��Name$ txtName��5      $��Username��6'   $��1��67   $��2��6D   $��Center=�6T   $��5.041,3.4,0,2.8q�5   &   $	��100��6?   $
��Left=�6N   $	��163��6i   �� 5      $��Password��6   $��2��6(   $��3,4.4,3,2.6q�65   $��13(�6J   $��2��6X   G� 5      -   5         G�Name$ UserPassword��5       G� Password$ Password��60   $��2��6E   $��2��6U   $��Center=�6b   $��5.041,3.2,0,2.8q�5   *   $	��100��6C   $
��Left=�6R   $	��163��6m   �� 5      $��Log in��6   $��3��5!      $��2��5"      $��5.041,8.2,-0.041,2.6q�5#      $��13(�5$      ��5       �� *EmployeesViewCommand+5$      5%      5&      5'      