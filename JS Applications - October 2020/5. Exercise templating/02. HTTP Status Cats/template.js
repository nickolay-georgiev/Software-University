
window.addEventListener('load', async function () {

    const rootEl = document.querySelector('#allCats');

    const template = await (await fetch('main-template.hbs')).text();
    const partialTemplate = await (await fetch('cat-template.hbs')).text();

    Handlebars.registerPartial('cat', partialTemplate);

    const templateFn = Handlebars.compile(template);
    const generatedHtml = templateFn({ cats });
    rootEl.innerHTML = generatedHtml;

    document.querySelector('#allCats > ul')
        .addEventListener('click', handler)

    function handler(e) {

        if (e.target.nodeName != 'BUTTON') { return; }

        const element = e.target.parentElement.querySelector('.status');

        if (element.style.display == 'none') {
            element.style.display = 'block';
            e.target.textContent = 'Hide status code';

        } else if (element.style.display == 'block') {
            element.style.display = 'none';
            e.target.textContent = 'Show status code';
        }
    }
})