<template>
  <div class="hello">
    <h1>{{ msg }}</h1>
    <p>
      Lorem ipsum, dolor sit amet consectetur adipisicing elit.
      Non natus provident, voluptatum iure tempore, consectetur aliquam voluptate,
      veniam rem expedita harum nam sapiente maiores ipsam iste perferendis accusantium vel deserunt.
    </p>
  </div>
</template>

<script>
export default {
  name: "HomePage",
  props: {
    msg: String
  }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
