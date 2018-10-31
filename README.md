# SerialPortHelper
SerialPortHelper是一款基于C#的串口助手类库。
项目处于开发测试阶段，未经充分测试与验证，不推荐用于生产环境。

> 目前操作逻辑可能随时变动，不保证接口与功能向后兼容。

欢迎加入测试并向我们提交BUG或建议，请下载最新[Releases](https://github.com/xiaoxinpro/SerialPortHelper/releases)版本参与测试！

## 开发状态
串口助手类库项目，目前基于 .NET Framework 3.5 构建。

> 使用文档：https://github.com/xiaoxinpro/SerialPortHelper/wiki

注意：目前处于开发阶段无法用于生产，有想法或建议请[Issues](https://github.com/xiaoxinpro/SerialPortHelper/issues)。

## 使用实例
详见 [SerialPortHelperTest](https://github.com/xiaoxinpro/SerialPortHelper/tree/master/SerialPortHelperTest) 串口助手类库测试项目，主要用于演示SerialPortHelper类库的各项功能与测试任务。

## 快速上手
这里只列举部分功能，详细操作文档请参考[使用文档](https://github.com/xiaoxinpro/SerialPortHelper/wiki)

### 前期准备
使用前需要引用 **SerialPortHelperLib**，可以直接将源码直接添加到解决方案中，也可以引用SerialPortHelperLib.dll文件；接下来在代码文件顶部添加 ：

    using SerialPortHelperLib;

即可开始使用串口助手类库。

### 初始化串口助手类
添加一个 **ComboBox** 控件，命名 **cbPortName** 。

    //实例化串口助手
    spb = new SerialPortHelper();
    
    //设置串口号ComboBox，并写入默认配置
    spb.ConfigSerialPort = new ConfigCom(cbPortName).GetConfigComData();
    
    //绑定接收数据函数
    spb.BindSerialPortDataReceivedProcessEvent(new SerialPortHelper.DelegateSerialPortDataReceivedProcessEvent(SerialPortDataReceivedProcess));

