import Vue from 'vue';
import Vuex from 'vuex';
import axios from 'axios';

Vue.use(Vuex);

export default new Vuex.Store({
    state: {
        expenses: []
    },
    mutations: {
        listExpenses() {
            return this.expenses.slice();
        },
        addExpense(state, expense) {
            state.expenses.push(expense);
        }
    },
    actions: {
        getExpenses(context) {
            axios.get("/api/expense")
                .then((response) => {
                    debugger;
                    const expensesToBeAdded = response.data.map(e => {
                        return {
                            title: e.title,
                            amount: e.expenseAmount
                        }
                    })
                    context.commit('addExpense', ...expensesToBeAdded);
                }).catch((err) => {
                    console.log(err);
                });

        },
        registerUser(user) {
            debugger;
            axios.post('/api/users/register', { email: user.email, password: user.password }).then(res => {
                debugger;
                console.log(res.data);
            });
        }
    }
})