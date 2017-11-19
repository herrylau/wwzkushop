var cssEl = document.createElement('style');
    document.documentElement.firstElementChild.appendChild(cssEl);
    (function(win,doc){
        var resize='orientationchange' in window?'orientationchange':'resize';
        function setPxPerRem() {
            var dpr = 1;
            var pxPerRem = document.documentElement.clientWidth * dpr / 32;
            if (pxPerRem < 10) pxPerRem = 10;
            if (pxPerRem > 20) pxPerRem = 20;
            cssEl.innerHTML = 'html{font-size:' + pxPerRem + 'px!important;}';
        }

        win.addEventListener(resize,setPxPerRem,false);
        win.addEventListener('load',setPxPerRem,false);
        doc.addEventListener('DOMContentLoaded',false);
    })(window,document);