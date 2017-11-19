var vShopApp = new plugIn(), 
                App = {

                    status: 0, //是否后端开发状态(0前端，1后端)

                    init: function () {        
                        /*test********************************************/
                        $('#testBtn').on('click', function () {
                            //alert();
                            //vShopApp.refresh();
                        });

                        //点击验证码时校验
                        $('#phoneCodeBtn').on('click', function () {
                            var _this = this, thisId = $(_this).attr('id'), res = vShopApp.getPhoneCord(_this, 'userPhone', 'passWordLoose', 'imgCode');
                            if (App.status) {//后端开发
                                if (res) {
                                    //前端校验通过,后端请求
                                    $.ajax({
                                        url: '',
                                        dataType: '',
                                        data: {},
                                        type: 'post',
                                        success: function () {
                                            //to do something...

                                            //执行倒计时
                                            vShopApp.codeTime(thisId, res, 120);
                                        },
                                        error: function () {

                                        }
                                    });
                                }
                            } else {//前端开发
                                if (res) {
                                    //执行倒计时
                                    vShopApp.codeTime(thisId, res, 120);
                                }
                            }
                        });

                        //点击提交按钮时校验
                        $('#submitBtn').on('click', function () {
                            var _this = this, res = vShopApp.submintForm(_this, '#userPhone', '#passWordLoose', '#imgCode', '#phoneCode');

                            if (App.status) {
                                if (res) {
                                    //前端校验通过,后端请求
                                    $.ajax({
                                        url: '',
                                        dataType: '',
                                        data: {},
                                        type: 'post',
                                        success: function () {
                                            window.location.href = 'http://www.baidu.com/'
                                            //等候加载提示
                                            vShopApp.alertMsg(vShopApp.loadingText, _this, 'loading');
                                        },
                                        error: function () {
                                            
                                        }
                                    });  
                                }
                            } else {
                                if (res) {
                                    window.location.href = 'http://www.baidu.com/';
                                    //跳转页面前的等候加载提示
                                    vShopApp.alertMsg(vShopApp.loadingText, _this, 'loading');
                                }
                            }
                        });

                        //半透明提示弹层
                        $('#alertMsg').on('click', function () {
                            var thisElement = $(this);
                            vShopApp.alertMsg('hello world~', thisElement);
                        });

                        //等候加载
                        $('#alertLoading').on('click', function () {
                            vShopApp.alertMsg(vShopApp.loadingText, null, 'loading', 'noClear');
                        });

                        //通用弹层--不带按钮自适应高度提示框
                        $('#layerNoBtn').on('click', function () {
                            vShopApp.tips({
                                title: '提示',
                                closeId: 'tipsCloseBtn',
                                content: '<div class="text-center">欢迎调用通用弹层组件。</div>',
                                alone: true
                            });
                        });

                        //通用弹层--不带按钮固定高度提示框
                        $('#layerNoBtnFull').on('click', function () {
                            vShopApp.tips({
                                title: '提示',
                                closeId: 'tipsCloseBtn',
                                content: '<div class="text-center">欢迎调用通用弹层组件。</div>',
                                fixedHeight: true
                            });
                        });

                        //通用弹层--带确定按钮自适应高度提示框
                        $('#layerOneBtn').on('click', function () {
                            vShopApp.tips({
                                title: '提示',
                                closeId: 'tipsCloseBtn',
                                btnNums: 1,
                                content: '恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!恭喜您成功调用碳层组件,再见!',
                                btn: {
                                    btnSure: {
                                        text: '确 定',
                                        href: 'javascript:void(0);'
                                    }
                                },
                                alone: true
                            });
                        });

                        //通用弹层--带确定按钮自适应高度提示框
                        $('#layerOneBtnFull').on('click', function () {
                            vShopApp.tips({
                                title: '提示',
                                closeId: 'tipsCloseBtn',
                                btnNums: 1,
                                content: '恭喜您成功调用碳层组件,再见!',
                                btn: {
                                    btnSure: {
                                        text: '确 定',
                                        href: 'javascript:void(0);'
                                    }
                                },
                                fixedHeight: true,
                                alone: true
                            });
                        });

                        //通用弹层--带确定按钮自动刷新页面提示框
                        $('#layerOneBtnRefresh').on('click', function () {
                            vShopApp.tips({
                                title: '提示',
                                closeId: 'tipsCloseBtn',
                                btnNums: 1,
                                content: '恭喜您成功调用碳层组件,再见!',
                                btn: {
                                    btnSure: {
                                        text: '确 定',
                                        href: 'javascript:void(0);',
                                        refresh: true
                                    }
                                },
                                alone: true
                            });
                        });

                        //通用弹层--带取消和确定按钮自适应高度
                        $('#layerTwoBtn').on('click', function () {
                            vShopApp.tips({
                                title: '提示',
                                closeId: 'tipsCloseBtn',
                                btnNums: 2,
                                content: '恭喜您成功调用碳层组件!\\这里是一个多行列表的弹层\\用"双反斜杠"可以实现分行，不信你可以试试。',
                                btn: {
                                    btnSure: {
                                        text: '前往列表页',
                                        href: 'javascript:void(0);',
                                        fun: function () {
                                            //真正使用时请去掉setTimeout方法
                                            setTimeout(function () {
                                                window.location.href = 'listloading.html';
                                            }, 1000);
                                        }
                                    },
                                    btnCancle: {
                                        text: '取 消',
                                        href: 'javascript:void(0);',
                                        fun: function () {
                                            console.log('xiaoyu222222~~~~~~');
                                        }
                                    }
                                }
                            });
                        });
                        
                        //通用弹层--带取消和确定按钮固定高度
                        $('#layerTwoBtnFull').on('click', function () {
                            vShopApp.tips({
                                title: '提示',
                                closeId: 'tipsCloseBtn',
                                btnNums: 2,
                                content: '恭喜您成功调用碳层组件!\\这里是一个多行列表的弹层\\用"双反斜杠"可以实现分行，不信你可以试试。',
                                btn: {
                                    btnSure: {
                                        text: '前往列表页',
                                        href: 'javascript:void(0);',
                                        fun: function () {
                                            //真正使用时请去掉setTimeout方法
                                            setTimeout(function () {
                                                window.location.href = 'listloading.html';
                                            }, 1000);
                                        }
                                    },
                                    btnCancle: {
                                        text: '取 消',
                                        href: 'javascript:void(0);',
                                        fun: function () {
                                            console.log('xiaoyu222222~~~~~~');
                                        }
                                    }
                                },
                                fixedHeight: true
                            });
                        });

                        //通用弹层--带取消和确定按不隐藏
                        $('#layerTwoBtnShow').on('click', function () {
                            vShopApp.tips({
                                title: '提示',
                                closeId: '',
                                btnNums: 2,
                                content: '恭喜您成功调用碳层组件!\\这里是一个多行列表的弹层\\用"双反斜杠"可以实现分行，不信你可以试试。',
                                btn: {
                                    btnSure: {
                                        text: '前往列表页',
                                        href: 'javascript:void(0);',
                                        fun: function () {
                                            var thisElement = $(this);
                                            window.location.href = 'index.html';
                                            //vShopApp.alertMsg('hello world~', thisElement);
                                        },
                                        display: true
                                    },
                                    btnCancle: {
                                        text: '取 消',
                                        href: 'javascript:void(0);',
                                        fun: function () {
                                            console.log('xiaoyu222222~~~~~~');
                                        }
                                    }
                                }
                            });
                        });

                        //通用弹层--带表单和按钮的提示框-return funciton
                        $('#layerBtnInput1').on('click', function () {
                            var inputHtml = '<form><ul class="list-unstyled list-p5">'
                                          + '<li><div class="form-group"><input id="bankCard" class="form-control numSept" type="tel" maxlength="23" placeholder="请输入银行卡号"></div></li>' 
                                          + '<li><div class="form-group"><input id="dealPassword" class="form-control" type="tel" maxlength="6" placeholder="请输入交易密码"></div></li>'
                                          + '</ul></form>';
                            vShopApp.tips({
                                title: '提示框表单',
                                closeId: 'tipsCloseBtn',
                                btnNums: 2,
                                content: inputHtml,
                                btn: {
                                    btnSure: {
                                        text: '确　定',
                                        href: 'javascript:void(0);',
                                        fun: function () {
                                            //分割长号码4位数空格
                                            vShopApp.NumberSeparation('numSept');
                                            //清除输入框文本控件
                                            vShopApp.clearInput();
                                            
                                            return function (thisElement) {
                                                var _this = thisElement, res = vShopApp.submintForm(_this, '#bankCard', '#dealPassword');
                                                
                                                if (App.status) {
                                                    if (res) {
                                                        //前端校验通过,后端请求
                                                        $.ajax({
                                                            url: '',
                                                            dataType: '',
                                                            data: {},
                                                            type: 'post',
                                                            success: function () {
                                                                window.location.href = 'http://www.baidu.com/'
                                                                //等候加载提示
                                                                vShopApp.alertMsg(vShopApp.loadingText, _this, 'loading');
                                                            },
                                                            error: function () {
                                                                
                                                            }
                                                        });  
                                                    }
                                                } else {
                                                    if (res) {
                                                        window.location.href = 'http://www.baidu.com/';
                                                        //跳转页面前的等候加载提示
                                                        vShopApp.alertMsg(vShopApp.loadingText, _this, 'loading');
                                                    }
                                                }
                                            };
                                        },
                                        display: true
                                    },
                                    btnCancle: {
                                        text: '取　消',
                                        href: 'javascript:void(0);',
                                        fun: function () {
                                            console.log('xiaoyu222222~~~~~~');
                                        }
                                    }
                                }
                            });
                        });

                        //通用弹层--带表单和按钮的提示框-return obj
                        $('#layerBtnInput2').on('click', function () {
                            var inputHtml = '<form><ul class="list-unstyled list-p5">'
                                          + '<li><div class="form-group"><input id="userPhone" class="form-control" type="tel" maxlength="11" placeholder="请输入您的手机号码"></div></li>' 
                                          + '<li><div class="form-group"><span class="left"><input id="phoneCode" class="form-control" type="tel" maxlength="6" placeholder="短信验证码"></span><span class="right"><a id="btnPhoneCode" class="btn btn-danger" href="javascript:void(0);">获取验证码</a></span></div></li>'
                                          + '</ul></form>';
                            vShopApp.tips({
                                title: '提示框表单',
                                closeId: 'tipsCloseBtn',
                                btnNums: 1,
                                fnCbs: 2,
                                content: inputHtml,
                                btn: {
                                    btnSure: {
                                        text: '确　定',
                                        href: 'javascript:void(0);',
                                        fun: function () {
                                            //清除输入框文本控件
                                            vShopApp.clearInput();

                                            return {
                                                btnPhoneCode: function (thisElement) {
                                                    var _this = thisElement, thisId = $(_this).attr('id'), res = vShopApp.getPhoneCord(_this, 'userPhone');
                                                    if (App.status) {//后端开发
                                                        if (res) {
                                                            //前端校验通过,后端请求
                                                            $.ajax({
                                                                url: '',
                                                                dataType: '',
                                                                data: {},
                                                                type: 'post',
                                                                success: function () {
                                                                    //to do something...

                                                                    //执行倒计时
                                                                    vShopApp.codeTime(thisId, res, 120);
                                                                },
                                                                error: function () {

                                                                }
                                                            });
                                                        }
                                                    } else {//前端开发
                                                        if (res) {
                                                            //执行倒计时
                                                            vShopApp.codeTime(thisId, res, 120);
                                                        }
                                                    }
                                                },
                                                btnSure: function (thisElement) {
                                                    var _this = thisElement, res = vShopApp.submintForm(_this, '#userPhone', '#phoneCode');
                                                    
                                                    if (App.status) {
                                                        if (res) {
                                                            //前端校验通过,后端请求
                                                            $.ajax({
                                                                url: '',
                                                                dataType: '',
                                                                data: {},
                                                                type: 'post',
                                                                success: function () {
                                                                    window.location.href = 'http://www.baidu.com/'
                                                                    //等候加载提示
                                                                    vShopApp.alertMsg(vShopApp.loadingText, _this, 'loading');
                                                                },
                                                                error: function () {
                                                                    
                                                                }
                                                            });  
                                                        }
                                                    } else {
                                                        if (res) {
                                                            window.location.href = 'http://www.baidu.com/';
                                                            //跳转页面前的等候加载提示
                                                            vShopApp.alertMsg(vShopApp.loadingText, _this, 'loading');
                                                        }
                                                    }
                                                }
                                            };
                                        },
                                        display: true
                                    }
                                }
                            });
                        });

                        /*
                        @ 分享组件nativeShare
                        @ 调用实例方法 nativeShare(shareBtnId, pcode, config)
                        @ shareBtnId = '分享按钮Id（带#）'
                        @ pcode = 'pcode活动码'
                        @ config = '包含分享内容配置的对象'
                        */
                        $('#nativeShareBtn').on('click', function () {
                            var nShare = new nativeShare('#nativeShareBtn', '0000', {
                                url:'http://www.baidu.com',
                                title:'这里是分享内容的标题',
                                desc:'这里是分享的内容描述',
                                img:'code.png',
                                img_title:'3333333333333',
                                from:'44444444444444444444'
                            });
                        });

                        $('#listLoadingBtn').on('click', function () {
                            vShopApp.alertMsg(vShopApp.loadingText, null, 'loading', 'noClear');
                            //真正使用时请去掉setTimeout方法
                            setTimeout(function () {
                                window.location.href = 'listloading.html';
                            }, 1000);
                        });

                        //滚动信息列表
                        vShopApp.scrollMsg('#scrollMsg', 2500, 5);

                        //页面底部固定按钮
                        vShopApp.fixedBtn('#fixedBtn');

                        //页面底部的跳动提示箭头
                        vShopApp.footerArrow('#iconArrow');        

                        //密码与明文显示切换
                        vShopApp.pwdShowHide('#passWordLoose');

                        //文本输入框添加一键删除功能
                        vShopApp.clearInput();

                        //苹果设备显示“活动与苹果公司无关的声明”
                        //vShopApp.activityStatement('本活动由光汇云油提供，与设备生产商Apple Inc.公司无关');
                    }
                };

        App.init();