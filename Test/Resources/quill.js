
const quill = new Quill('#richtext', {
    modules: {
        toolbar: [
            [{ 'header': 1 }, { 'header': 2 }, { 'header': 3 }],  
            ['bold', 'italic'],
            [{ 'script': 'sub' }, { 'script': 'super' }], 
            ['link', 'blockquote', 'code-block', 'image'],
            [{ list: 'ordered' }, { list: 'bullet' }],
        ],
    },
    theme: 'snow',
});


const form = document.querySelector('form');
form.addEventListener('formdata', (event) => {
    // Append Quill content before submitting
    event.formData.append('Body', quill.getSemanticHTML());
});

document.querySelector('#resetForm').addEventListener('click', () => {
    resetForm();
});