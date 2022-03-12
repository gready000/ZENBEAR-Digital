
window.onload = function () {
    var typeSel = document.getElementById("Department"),
        fieldSel = document.getElementById("Jobtitle")
    for (var type in typeObject) {
        typeSel.options[typeSel.options.length] = new Option(type, type);
    }
    typeSel.onchange = function () {
        fieldSel.length = 1; // remove all options bar first
        if (this.selectedIndex < 1) return; // done
        var ft = typeObject[this.value];
        for (var field in typeObject[this.value]) {
            fieldSel.options[fieldSel.options.length] = new Option(ft[field], field);
        }
    }
    typeSel.onchange();
}