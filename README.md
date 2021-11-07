# 每日精选技术文档
## 整体框架
- 1:先通过提供的json文件读取数据并创建对象，在创建UI对象的时候解析这些数据成为他们的属性。
- 2:通过json给的数据判断需要创建的预置物。
- 3:导入美术资源
- 4:根据需求文档确定整个UI的层级和结构。
- 5:根据需求文档实现具体的功能并测试

## 目录结构
```
├── Readme.md               #技术文档                    
├── config                     
│   ├── SimpleScence        #场景
├── internal
│   ├── Duqu        #读取配置文件
│   ├── Manager         #生成对象
│   ├── Read        #数据类
│   ├── Move                 #点击触发金币飞出
│   ├── Buycoin         #触发点击事件
├── pkg                     
│   ├── SimpleJson
│   ├── DoTween

```




## 代码
| 需要的脚本       |     实现的功能 |
| ------ | ------                |
| 数据读取脚本 |  读取并解析json数据   |
| UI控制脚本   |  通过判断type搭建ui界面   |
| 金币控制脚本 |  控制金币飞出和金币增加脚本  |


## 层级分析
```
├── MainCamera
├── Duqu                   #读取数据
├── Canvans
│   ├── StartButton
│   ├── CloseButton	
│   ├── DailyTitle #每日精选模块
│   ├── ScrowView		
│       ├── Content		
│           ├── EverydayOption    #产生UI对象
│           ├── ShiBing  #士兵招募模块   

```
## 第三方库：
- 1:Simplejson:用于解析json数据
- https://github.com/simplejson/simplejson
- 2:Dotween:用于实现金币的移动
- https://github.com/Demigiant/dotween

![每日精选](https://user-images.githubusercontent.com/92706401/140639430-4cd8c87a-948d-4ce8-9d66-e5e53cc62c1b.png)


