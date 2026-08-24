using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// 查询劳动者退款订单信息返回
    /// </summary>
    public class GetLaborRefundOrderResponseModel : AopObject
    {
        /// <summary>
        /// 综合服务主体 ID
        /// </summary>
        [JsonProperty("broker_id")]
        public string BrokerID { get; set; }

        /// <summary>
        /// 平台企业 ID
        /// </summary>
        [JsonProperty("dealer_id")]
        public string DealerID { get; set; }

        /// <summary>
        /// 综合服务平台流水号
        /// </summary>
        [JsonProperty("ref")]
        public string Ref { get; set; }

        /// <summary>
        /// 退款流水号
        /// </summary>
        [JsonProperty("refund_ref")]
        public string RefundRef { get; set; }

        /// <summary>
        /// 平台企业订单号
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderID { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        [JsonProperty("id_card")]
        public string IDCard { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 退款类型
        /// </summary>
        [JsonProperty("refund_type")]
        public string RefundType { get; set; }

        /// <summary>
        /// 退款总金额
        /// </summary>
        [JsonProperty("refund_total_amount")]
        public string RefundTotalAmount { get; set; }

        /// <summary>
        /// 退回劳动者实收金额
        /// </summary>
        [JsonProperty("refund_user_real_amount")]
        public string RefundUserRealAmount { get; set; }

        /// <summary>
        /// 是否退加成服务费
        /// </summary>
        [JsonProperty("is_refund_fee")]
        public string IsRefundFee { get; set; }

        /// <summary>
        /// 退回劳动者加成服务费金额
        /// </summary>
        [JsonProperty("refund_user_fee")]
        public string RefundUserFee { get; set; }

        /// <summary>
        /// 退回平台企业加成服务费金额
        /// </summary>
        [JsonProperty("refund_broker_fee")]
        public string RefundBrokerFee { get; set; }

        /// <summary>
        /// 退回平台企业服务费实收金额
        /// </summary>
        [JsonProperty("refund_real_fee")]
        public string RefundRealFee { get; set; }

        /// <summary>
        /// 退回平台企业服务费抵扣金额
        /// </summary>
        [JsonProperty("refund_deduct_fee")]
        public string RefundDeductFee { get; set; }

        /// <summary>
        /// 是否退税费
        /// </summary>
        [JsonProperty("is_refund_tax")]
        public string IsRefundTax { get; set; }

        /// <summary>
        /// 退回税费总额
        /// </summary>
        [JsonProperty("refund_tax_amount")]
        public string RefundTaxAmount { get; set; }

        /// <summary>
        /// 退回个税金额
        /// </summary>
        [JsonProperty("refund_personal_tax")]
        public string RefundPersonalTax { get; set; }

        /// <summary>
        /// 退回增值税金额
        /// </summary>
        [JsonProperty("refund_value_added_tax")]
        public string RefundValueAddedTax { get; set; }

        /// <summary>
        /// 退回附加税金额
        /// </summary>
        [JsonProperty("refund_additional_tax")]
        public string RefundAdditionalTax { get; set; }

        /// <summary>
        /// 退回已追缴个税
        /// </summary>
        [JsonProperty("refund_labor_recovery_personal_tax")]
        public string RefundLaborRecoveryPersonalTax { get; set; }

        /// <summary>
        /// 退回已追缴增附税
        /// </summary>
        [JsonProperty("refund_labor_recovery_added_tax")]
        public string RefundLaborRecoveryAddedTax { get; set; }

        /// <summary>
        /// 退回劳动者个税
        /// </summary>
        [JsonProperty("refund_user_personal_tax")]
        public string RefundUserPersonalTax { get; set; }

        /// <summary>
        /// 退回劳动者增值税
        /// </summary>
        [JsonProperty("refund_user_value_added_tax")]
        public string RefundUserValueAddedTax { get; set; }

        /// <summary>
        /// 退回劳动者附加税
        /// </summary>
        [JsonProperty("refund_user_additional_tax")]
        public string RefundUserAdditionalTax { get; set; }

        /// <summary>
        /// 退回平台企业个税
        /// </summary>
        [JsonProperty("refund_dealer_personal_tax")]
        public string RefundDealerPersonalTax { get; set; }

        /// <summary>
        /// 退回平台企业增值税
        /// </summary>
        [JsonProperty("refund_dealer_value_added_tax")]
        public string RefundDealerValueAddedTax { get; set; }

        /// <summary>
        /// 退回平台企业附加税
        /// </summary>
        [JsonProperty("refund_dealer_additional_tax")]
        public string RefundDealerAdditionalTax { get; set; }

        /// <summary>
        /// 退回云账户个税
        /// </summary>
        [JsonProperty("refund_broker_personal_tax")]
        public string RefundBrokerPersonalTax { get; set; }

        /// <summary>
        /// 退回云账户增值税
        /// </summary>
        [JsonProperty("refund_broker_value_added_tax")]
        public string RefundBrokerValueAddedTax { get; set; }

        /// <summary>
        /// 退回云账户附加税
        /// </summary>
        [JsonProperty("refund_broker_additional_tax")]
        public string RefundBrokerAdditionalTax { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        [JsonProperty("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 退款创建时间
        /// </summary>
        [JsonProperty("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 退款完成时间
        /// </summary>
        [JsonProperty("finished_at")]
        public string FinishedAt { get; set; }

    }
}
