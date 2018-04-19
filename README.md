# SerialPortHelper 解决方案
基于C#的串口助手类库，目前处于开发初期，主要以构思框架为主。

## SerialPortHelperLib 项目
串口助手类库项目，目前基于 .NET Framework 3.5 构建。

### DetectCom类
检测Com口的类，可以订阅事件进行自动检测，串口列表发生变化时触发事件。

#### 简单实现自动刷新串口列表

```
//实例化自动刷新（简单实例）
DetectCom dc = new DetectCom(new DetectCom.DelegateSerialPortListEvent(AutoReflashSericalPortList));

//打开自动刷新
dc.Open();
```

#### 自定义使用线程刷新串口列表

使用`DetectComMode`属性来指定刷新串口的方式，包括`Timer 定时器`和`Thread 线程`两种方式。

若不指定`DetectComMode`属性，默认使用定时器刷新串口列表。

```
//实例化自动刷新
DetectCom dc = new DetectCom(new DetectCom.DelegateSerialPortListEvent(AutoReflashSericalPortList));

//线程刷新
dc.DetectComMode = DetectComModeEnum.Thread;

//打开自动刷新
dc.Open();
```

#### 自定义串口刷新时间间隔

使用`DetectComMode`属性来指定刷新串口的时间间隔（毫秒），该属性可跟项目要求自行设定。

建议刷新间隔设定在100至500毫秒范围内，设定值太小浪费系统资源，设定值太大响应速度慢。

若不指定`DetectComInterval`属性，默认刷新间隔为300毫秒。

```
//实例化自动刷新
DetectCom dc = new DetectCom(new DetectCom.DelegateSerialPortListEvent(AutoReflashSericalPortList));

//设置刷新间隔100ms
dc.DetectComInterval = 100;

//打开自动刷新
dc.Open();
```

## SerialPortHelperTest 项目
串口助手类库测试项目，主要用于演示SerialPortHelper类库的各项功能与测试任务。
