# SerialPortHelper
SerialPortHelper是一款基于C#的串口助手类库。
项目处于开发测试阶段，未经充分测试与验证，不推荐用于生产环境。

> 目前操作逻辑可能随时变动，不保证接口与功能向后兼容。

欢迎加入测试并向我们提交BUG或建议，请下载最新[Releases](https://github.com/xiaoxinpro/SerialPortHelper/releases)版本参与测试！

## 开发状态
串口助手类库项目，目前基于 .NET Framework 3.5 编译，若需要 .NET Framework 4+ 可以直接自行修改框架编译。

> 使用文档：https://github.com/xiaoxinpro/SerialPortHelper/wiki

注意：目前处于开发阶段无法用于生产，有想法或建议请[Issues](https://github.com/xiaoxinpro/SerialPortHelper/issues)。

## 使用实例
详见 [SerialPortHelperTest](https://github.com/xiaoxinpro/SerialPortHelper/tree/master/SerialPortHelperTest) 串口助手类库测试项目，主要用于演示SerialPortHelper类库的各项功能与测试任务。

## 快速上手
这里只列举部分功能，详细操作文档请参考[使用文档](https://github.com/xiaoxinpro/SerialPortHelper/wiki)

### 前期准备
使用前需要引用 ```SerialPortHelperLib```，可以直接将源码直接添加到解决方案中，也可以引用```SerialPortHelperLib.dll```文件；接下来在代码文件顶部添加 ：

    using SerialPortHelperLib;

即可开始使用串口助手类库。

### 初始化串口助手类
首先需要定义一个全局类

    //定义SerialPortHelper类
    private SerialPortHelper spb;

然后添加一个 ```ComboBox``` 控件，命名 ```cbPortName``` 。

最后在窗体加载中加入初始化代码：

    //实例化串口助手
    spb = new SerialPortHelper();
    
    //设置串口号ComboBox，并写入默认配置
    spb.ConfigSerialPort = new ConfigCom(cbPortName).GetConfigComData();
    
若要自定义串口配置可以定义ConfigCom类：

    //定义ConfigCom类
    private ConfigCom cc;
    
    //修改配置
    cc = new ConfigCom(cbSerial);
    cc.BaudRate = 14400;
    cc.DataBits = 7;
    cc.StopBits = StopBits.OnePointFive;
    cc.Parity = Parity.Even;

    //写入串口配置
    spb.ConfigSerialPort = cc.GetConfigComData();

### 开启串口
使用 ```OpenCom``` 开启串口，需要传入一个```out```字符串，用于返回错误信息。

    spb.OpenCom(out string strError);
    if(strError != "null")
    {
      //串口开启失败
      MessageBox.Show(strError);
    }

### 关闭串口
与开启串口类似，使用 ```CloseCom``` 方法关闭串口。

    spb.CloseCom(out string strError);
    if (strError != "null")
    {
      //关闭串口失败
      MessageBox.Show(strError);
    }

### 发送数据

发送Byte数组到串口：

    spb.Write(Byte数组);

发送十六进制到串口：

    spb.Write(SerialData.ToHexByteArray(十六进制字符串));

发送字符串到串口：

    spb.Write(SerialData.ToByteArray(字符串));

### 接收数据
若要接收数据，需要在串口初始化时增加接收事件绑定：

    //串口助手类初始化
    //绑定接收数据函数SerialPortDataReceivedProcess
    spb.BindSerialPortDataReceivedProcessEvent(new SerialPortHelper.DelegateSerialPortDataReceivedProcessEvent(SerialPortDataReceivedProcess));

绑定的方法 ```SerialPortDataReceivedProcess``` 示例如下：

    /// <summary>
    /// 串口接收数据处理
    /// </summary>
    /// <param name="arrData">接收数据数组</param>
    private void SerialPortDataReceivedProcess(byte[] arrData)
    {
        this.Invoke(new Action(() =>
        {
            //串口数据处理
        }));
    }

> 关于接收数据转换可参考Wiki中的 [SerialData](https://github.com/xiaoxinpro/SerialPortHelper/wiki/SerialData) 部分。


## 开发计划
计划在后续版本中加入的功能与优化，如果有其他功能建议欢迎在 [issues](https://github.com/xiaoxinpro/SerialPortHelper/issues) 中反馈。

* 简化检测串口流程，删除多余的重复功能。
* 增加接收数据同步获取，与现有的异步获取可同时使用。
* 进一步完善[Wiki](https://github.com/xiaoxinpro/SerialPortHelper/wiki)文档。

