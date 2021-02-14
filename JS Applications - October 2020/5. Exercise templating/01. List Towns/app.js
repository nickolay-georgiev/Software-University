window.addEventListener('load', async () => {
    const rootEl = document.querySelector('#root > ul');
    const inputEl = document.querySelector('#towns');

    const templateString = await (await fetch('./main-template.hbs')).text();
    Handlebars.registerPartial('town', await (await fetch('./town-template.hbs')).text());

    document.querySelector('#btnLoadTowns').addEventListener('click', function (e) {
        e.preventDefault();

        let towns = inputEl.value.split(',').map(x => x.trim()).filter(x => x != '');
        if (towns.length === 0) { return; };

        const templateFn = Handlebars.compile(templateString);
        const generatedHtml = templateFn({ towns });
        rootEl.innerHTML = generatedHtml;
    })
})