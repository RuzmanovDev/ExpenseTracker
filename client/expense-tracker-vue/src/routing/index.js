import Vue from 'vue';
import Router from 'vue-router';

import HomePage from '../components/HomePage.vue';
import ExpenseList from '../expense/ExpenseList.vue';

Vue.use(Router);

export default new Router({
    routes:[
        {
            path: '/',
            name: 'Home',
            component: HomePage
        },
        {
            path: '/expenses',
            name: 'ExpenseList',
            component: ExpenseList
        }
    ]
});