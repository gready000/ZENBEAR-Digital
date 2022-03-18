const data2 = {
    columns: ['Issue Type', 'Key', 'Reporter', 'Create On',],
    rows: [
        ['Hardware', 'TI-345', 'Borislav Ivanov', '2011/04/25', ],
        ['Software', 'TI-763', 'Teodor Nenchev', '2011/05/24',],
        
    ],
};

const instance = new mdb.Datatable(document.getElementById('datatable'), data2)

document.getElementById('datatable-search-input').addEventListener('input', (e) => {
    instance.input - group(e.target.value);
});