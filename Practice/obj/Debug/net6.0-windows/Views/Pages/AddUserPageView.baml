   M S B A M L   `   `   `  ����C  ?Practice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Practice.Views.PagesPractice.Views.Pages  5      *    $Practice.Views.Pages.AddUserPageView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Practice.Views.Pages     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	        N� Title$  AddUserPageView��5
      .��5      � 
�������.+�5   
   �� $	��500��6   $��Center=�6!   $��Center=�6>   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��5q�62   .+�5      �� $��18(�6   $
��Name��6&   $��70��65   $��Center=�6@   $
��Left=�6[   $��0 0 10 0q�6v   �� 5      $��18(�6]   $	��400��6k   $��Right=�6w   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Enter Name��5      ��5      �� *	User.name+ �� UpdateSourceTrigger$ PropertyChanged=�5      5      �� 5      $ 
Horizontal=�6   $��5q�62   .+�5      �� $��14(�6   $��Username��6&   $��70��69   $��Center=�6D   $
��Left=�6_   $��0 0 10 0q�6z   �� 5      $��18(�6_   $	��400��6m   $��Right=�6y   $ Enter Username��5      ��5      �� *User.username+$ PropertyChanged=�5      5      �� 5      $ 
Horizontal=�6   $��5q�62   .+�5      �� $��18(�6   $��Email��6&   $��70��66   $��Center=�6A   $
��Left=�6\   $��0 0 10 0q�6w   �� 5      $��18(�6\   $	��400��6j   $��Right=�6v   $ Enter Email��5       ��5      �� *
User.email+$ PropertyChanged=�5       5!      �� 5$      $ 
Horizontal=�6   $��5q�62   .+�5%      �� $��18(�6   $��Street��6&   $��70��67   $��Center=�6B   $
��Left=�6]   $��0 0 10 0q�6x   �� 5&      $��18(�6e   $	��400��6s   $��Right=�6   $ Enter Street��5'      ��5&      �� *User.address.street+$ PropertyChanged=�5'      5(      �� 5+      $ 
Horizontal=�6   $��5q�62   .+�5,      �� $��18(�6   $
��City��6&   $��70��65   $��Center=�6@   $
��Left=�6[   $��0 0 10 0q�6v   �� 5-      $��18(�6b   $	��400��6p   $��Right=�6|   $ 
Enter City��5.      ��5-      �� *User.address.city+$ PropertyChanged=�5.      5/      �� 52      $ 
Horizontal=�6   $��5q�62   .+�53      �� $��17(�6   $��Website��6&   $��70��68   $��Center=�6C   $
��Left=�6^   $��0 0 10 0q�6y   �� 54      $��18(�6]   $	��400��6k   $��Right=�6w   $ Enter Website��55      ��54      �� *User.website+$ PropertyChanged=�55      56      �� 59      $ 
Horizontal=�6   $��5q�62   .+�5:      �� $��17(�6   $��C:Name��6&   $��70��67   $��Center=�6B   $
��Left=�6]   $��0 0 10 0q�6x   �� 5;      $��18(�6c   $	��400��6q   $��Right=�6}   $ Enter Company Name��5<      ��5;      �� *User.company.name+$ PropertyChanged=�5<      5=      �� 5A      $ 
Horizontal=�6   $��5q�62   .+�5B      �� $��17(�6   $
��C:Bs��6&   $��70��65   $��Center=�6@   $
��Left=�6[   $��0 0 10 0q�6v   �� 5C      $��18(�6_   $	��400��6m   $��Right=�6y   $ Enter Company BS��5D      ��5C      �� *User.company.bs+$ PropertyChanged=�5D      5E      �� 5H      $	��150��65   $
��SAVE��6A   ��6   �� *SaveCommand+6A   5I      �� 5L   
   $
��BACK��61   $	��Top=�6@   $��70��6X   $��	10 10 0 0q�6c   $
��Left=�6v   ��6   �� *BackCommand+6v   5N      5O      