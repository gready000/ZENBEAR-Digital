var show = document.getElementById('show');
var hide = document.getElementById('hide');
var form = document.getElementById('form');
var textarea = document.getElementById('textarea');
show.addEventListener('click', function () {
    form.style = ('display: block');
    textarea.style = ('animation: riseHeight 1s .1s normal forwards');
    hide.style = ('display: block');
    show.disabled = true;
})
hide.addEventListener('click', function () {
    form.style = ('display: none');
    hide.style = ('display: none');
    show.disabled = false;
})