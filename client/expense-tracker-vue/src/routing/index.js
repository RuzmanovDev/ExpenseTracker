import Vue from 'vue';
import Router from 'vue-router';

import HomePage from '../components/HomePage.vue';
import ExpenseList from '../expense/ExpenseList.vue';
import RegisterPage from '../auth/RegisterPage.vue';
import LoginPage from '../auth/LoginPage.vue';

Vue.use(Router);

export default new Router({
    routes: [
        {
            path: '/',
            name: 'home',
            component: HomePage
        },
        {
            path: '/expenses',
            name: 'expense-list',
            component: ExpenseList
        },
        {
            path: '/register',
            name: "register",
            component: RegisterPage
        },
        {
            path: '/login',
            name: "login",
            component: LoginPage
        }
    ]
});