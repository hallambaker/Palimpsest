const initialData = {
    name: 'Wall-E',
    location: 'Earth',
    // `about` is a Delta object
    // Learn more at: https://quilljs.com/docs/delta
    about: [
        {
            insert:
                'A robot who has developed sentience, and is the only robot of his kind shown to be still functioning on Earth.\n',
        },
    ],
};

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

const resetForm = () => {
    document.querySelector('[name="name"]').value = initialData.name;
    document.querySelector('[name="location"]').value = initialData.location;
    quill.setContents(initialData.about);
};

resetForm();

const form = document.querySelector('form');
form.addEventListener('formdata', (event) => {
    // Append Quill content before submitting
    event.formData.append('about', quill.getSemanticHTML());
});

document.querySelector('#resetForm').addEventListener('click', () => {
    resetForm();
});5