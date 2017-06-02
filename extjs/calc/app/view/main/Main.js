Ext.define('Calc.view.main.Main', {
    extend: 'Ext.window.Window',
    
    /*加载视图之前就需要加载这些classes*/ 
    requires: [
        'Calc.view.main.MainController',
        'Calc.view.main.MainModel'
    ],
        
    xtype: 'app-main',
    controller: 'main',
    //用花括号可以写入多个项
    viewModel: {
        type: 'main'
    },  
    
    resizable: false,
    layout: {
        type: 'table',
        columns: 4
    },
    
    /* 默认设置，子类可以重写上面的*/

    defaultType: 'button',
    defaults: {
        width: 50,
        height: 50,
        cls: 'btn',
        handler: 'onClickNumber'
    },

    /* 使用window的header来显示计算机的header*/
    header: {
        items: [
            {
                xtype: 'displayfield',
                colspan: 4,
                width: 200,
                cls: 'display',
                bind: { 
                    value: '{display}'
                },
                height: 60,
                padding: 0

            }]
    },
    items: [
        {
            text: 'C',
            colspan: 2,
            width: 100,
            cls: 'btn-green',
            handler: 'onClickClear'
        },
        {
            text: '+/-',
            cls: 'btn-green',
            handler: 'onClickChangeSign'
        },
        {
            text: '&divide;',
            cls: 'btn-orange',
            handler: 'onClickOp'
        },
        {
            text: '7'
        },
        {
            text: '8'
        },
        {
            text: '9'
        },
        {
            text: '&times;',
            cls: 'btn-orange',
            handler: 'onClickOp'
        },
        {
            text: '4'
        },
        {
            text: '5'
        },
        {
            text: '6'
        },
        {
            text: '-',
            cls: 'btn-orange',
            handler: 'onClickOp'
        },
        {
            text: '1'
        },
        {
            text: '2'
        },
        {
            text: '3'
        },
        {
            text: '+',
            cls: 'btn-orange',
            handler: 'onClickOp'
        },
        {
            text: '0',
            width: 100,
            colspan: 2
        },
        {
            text: '.',
            handler: 'onClickDot'
        },
        {
            text: '=',
            cls: 'btn-orange',
            handler: 'onClickOp'
        }
    ]
});