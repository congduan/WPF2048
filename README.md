# WPF2048
A WPF 2048 Game

一个使用WPF写的2048游戏。  
除了可以设置行数和列数之外，支持修改显示名称。  
游戏逻辑比较简单，大家都应该玩过。  
这里主要实现了四个类：Game、GameBoard还有ColorBlock和BoardGridLine。  
Game类主要用来实现游戏的控制，比如初始化、添加新的色块、移除色块、控制色块上下左右移动、改变积分，触发游戏结束等。  
GameBoard继承自Canvas，实现了色块的合并、检测每个格子的状态等，另外提供了Game控制色块移动的接口。  
ColorBlock类继承自Shape类，用于自定义色块的显示，包含XY坐标、颜色、显示文字等依赖属性，可以进行动画，另外还实现了具体的上下左右移动的方法。最初几个颜色是手动设置，等到色块越来越多，就随机生成一种颜色。  
BoardGridLine也继承自Shape类，用于绘制Canvas底部的网格。  
另外，游戏使用一个简单的文本文件保存设置，包括行数与列数，以及显示文字及其对应颜色，具体操作在Settings类中。  

![image1](http://img.blog.csdn.net/20141230225156312?watermark/2/text/aHR0cDovL2Jsb2cuY3Nkbi5uZXQvY29uZ2R1YW4=/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70/gravity/SouthEast)

![image2](http://img.blog.csdn.net/20141230225618984)

![image3](http://img.blog.csdn.net/20141230225628031)
