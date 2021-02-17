import { home } from './controllers/home.js';
import { about } from './controllers/about.js';
import { login, loginPost, logout } from './controllers/login.js';
import { register, registerPost } from './controllers/register.js';

import { edit } from './controllers/edit.js';
import { create, createPost } from './controllers/create.js';
import { catalog, details } from './controllers/catalog.js';

window.addEventListener('load', () => {

    let app = Sammy('#main', function () {
        this.use('Handlebars', 'hbs');

        this.userData = {
            loggedIn: false,
            hasTeam: false,
        }

        this.get('index.html', home)
        this.get('#/home', home)
        this.get('/', home)

        this.get('#/about', about);

        this.get('#/login', login);
        this.get('#/logout', logout);
        this.get('#/register', register);


        this.get('#/catalog', catalog);
        this.get('#/catalog/:id', details);

        this.get('#/create', create);
        this.get('#/edit', edit);

        this.post('#/register', (ctx) => { registerPost.call(ctx) });
        this.post('#/login', (ctx) => { loginPost.call(ctx) });
        this.post('#/create', (ctx) => { createPost.call(ctx) });
    });

    app.run();
})