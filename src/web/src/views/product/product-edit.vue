
<template>
  <div>
    <el-row>
      <el-col :span="4">
        <div class="grid-content bg-purple">材料名称：</div>
      </el-col>
      <el-col :span="4">
        <div class="grid-content bg-purple-light">
          <el-input v-model="model.productName" placeholder="请输入内容"></el-input>
        </div>
      </el-col>
      <el-col :span="4">
        <div class="grid-content bg-purple">材料编码：</div>
      </el-col>
      <el-col :span="4">
        <div class="grid-content bg-purple-light">
          <el-input v-model="model.productCode" placeholder="请输入内容"></el-input>
        </div>
      </el-col>
      <el-col :span="4">
        <div class="grid-content bg-purple"></div>
      </el-col>
      <el-col :span="4">
        <div class="grid-content bg-purple-light"></div>
      </el-col>
    </el-row>
    <el-row>
      <el-button type="primary" @click="save()" >保存</el-button>
      <el-button>取消</el-button>
    </el-row>
  </div>
</template>
<style>
.el-row {
  margin-bottom: 20px;
  &:last-child {
    margin-bottom: 0;
  }
}
.el-col {
  border-radius: 4px;
}
.bg-purple-dark {
  background: #99a9bf;
}
.bg-purple {
  background: #d3dce6;
}
.bg-purple-light {
  background: #e5e9f2;
}
.grid-content {
  border-radius: 4px;
  min-height: 36px;
}
.row-bg {
  padding: 10px 0;
  background-color: #f9fafc;
}
</style>
<script>
export default {
  created() {
    this.getData();
  },

  methods: {
    getData() {
      var self = this;
      this.$http
        .get("/api/Product/63976446-EBB1-4961-A744-000097889186")
        .then(function(res) {
          console.log(res);
          self.model = res.data;
        })
        .catch(function(error) {
          console.log(error);
        });
    },
    save(){
        
        var self = this;
        console.log(self.model);
        this.$http
        .post("/api/Product/",self.model)
        .then(function(res) {
          console.log(res);
          self.model = res.data;
        })
        .catch(function(error) {
          console.log(error);
        });
    }
  },
  data() {
    return {
      model: ""
    };
  }
};
</script>